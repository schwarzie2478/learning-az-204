---
status: planted
dg-publish: true
ms-learn-url: (https://learn.microsoft.com/en-us/azure/app-service/)
definition: Azure App Service is an HTTP-based service for hosting web applications, REST APIs, and mobile back ends. You can develop in your favorite programming language or framework.
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-02 22:00

---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
- Built-in [[App Service Auto Scaling|Auto Scale Support]]
- [[Continuous Integration|CI]]/[[Continuous Deployment|CD]] Support
- [[Azure Deployment Slots]]
- [[Azure App Service on Linux]] ( [[Azure App Service on Linux#Limitations|with limitation]])



Used to deploy  a [[Azure WebApp]] and/or [[Azure Functions]]. ( not always possible together!)
You need a  [[Azure Subscription|subscription]], [[Azure Resource Group|resource group]] and an [[App Service Plan|plan]].
### Fast Creation Option

Instead of going through the wizard to create all the difference things
you can also use the [[Azure CLI]] with one do it all command

> [!example] 
> az webapp up --location xxx --name xxx

The opposite command ( not sure if this works with only location, probably needs resourcegroup)

> [!example] 
> az webapp delete --name xxx --location xxx

For locations: [[Azure Location]]

> [!attention] 
> This will create a lot of things with default settings, like resource groups and app service plan
> 

### Deployment options

Code (Github Actions)
Docker
Static Web App

Attention: You cannot deploy an pre-compiled exe binary to an App Service

### Recommended Service

Deploy with DB
Add Azure Cache for Redis

### Zone Redundancy

Only availible in Production SKU ( Premium)
Also to specify multiple application service plans (different buildings in Datacenter as consequence

### Enable Network inject

Only availible in Premium SKU
Add App to virtual network, to give access to service on that network that can't access the outside world


## Deploying my app

When the App Service is running, you can use quickstarts to start a deployment of your code

* GitHub Actions
* Azure DevOps
* DropBox
### Scaling my app

Built-in auto scale support

#### Scaling Tiers
Scale Up:  Go to bigger tier -> no downtime ( different from VM)
Scale Out: how many instances ( in Basic Tier only manual scaling)

Overview: [[App Service Plan#App Service Plan SKU| SKU]]

### Publishing from Visual Studio

use publish wizard

#### scm 

Every App Service has a site extension to allow for software configuration management ( SCM)

if your site is configured as  mysite.azurewebsites.net,  the scm is reachable at  mysite.scm.azurewebsites.net

This is powered by the Kudu Service: [[Kudu]]


### Deployment slots

Development SKU only have one slot -> production slot
Starting from the S en P SKU you have 5 - x slots.

later you can switch deployments into production  no downtime!
Now instead of  publishing in production, you can swap slots.
If the new version doesn't work well, you can quickly swap back the previous production version.

TODO Deployment slot configuration setup
TODO Secure ConnectionString by overriding the value in the App Settings page in the Portal

### TLS/ SSL Settings

If possible configure TLS 1.2 for most secure setting

If you have a custom domain, you need to provide a certificate from a certificate authority ( Let's Encrypt f.e.)

azurewebsites.net has its own wildstar certificate for all its site names.

### Auto Scaling

Scaling up a rule on an metric for example:  CPU load above 75% during 30min
Don't forget to put a scale down rule

Scaleing on an shedule ( working hours, midday day rush)

Metrics can also contain alerts ( perhaps coming from third-party tools like Prometheus)

## Cloning an App

You can't just move an App to an other region.
But Azure provide a clone process to alllow you to create a clone in an new or an other existing App Service Plan

With New-AZWebApp you can clone the existing app in an other App Service Plan

```powershell
$srcapp = Get-AzWebApp -ResourceGroupName SourceAzureResourceGroup -Name source-webapp
New-AzAppServicePlan -Location "North Central US" -ResourceGroupName DestinationAzureResourceGroup -Name DestinationAppServicePlan -Tier Standard
$destapp = New-AzWebApp -ResourceGroupName DestinationAzureResourceGroup -Name dest-webapp -Location "North Central US" -AppServicePlan DestinationAppServicePlan -SourceWebApp $srcapp

```
## App Service Logs

### Application Logging

    Can write to filesystem or blob storage
    log files can be accessed by FTP

### Web Server Logging

### Failed Request logs

See calls to unknown pages and such

### Detail Error Message

## Diagnostics Settings

logs and metrics to be sent to monitoring

for example log analytics workspace
   access azure monitor serivce
