---
ms-learn-url: (https://learn.microsoft.com/en-us/azure/app-service/)
---







## Requirements

To be able to deploy an [[Azure WebApp]],
You need an Subscription, ResourceGroup and an [[App Service Plan]]
## Creation Options

Instead of going through the wizard to create all the difference things
you can also use the [[Azure CLI]] with one do it all command

> [!example] 
> az webapp up --location xxx --name xxx

> [!attention] 
> This will create a lot of things with default settings, like resource groups and app service plan
> 

### Deployment options

Code (Github Actions)
Docker
Static Web App

Attention: You cannot deploy an pre-compiled exe binary to an App Service

### [[App Service Plan]]




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
...


### Scaling my app

Scale Up:  Go to bigger tier -> no downtime ( different from VM)
Scale Out: how many instances ( in Basic Tier only manual scaling)

General guidelines
| Column1  | Column2   | Column3   |
|-------------- | -------------- | -------------- |
| Item1    | Item1     | Item1     |


| App Service Plan SKU | Max Apps |
|--------------------- | --------- |
| B1, S1, P1v2, I1v1   | 8        |
|B2, S2, P2v2, I2v1	|16|
|B3, S3, P3v2, I3v1	| 32 |
|P0v3	| 8|
|P1v3, I1v2	| 16|
|P2v3, I2v2, P1mv3 |	32|
|P3v3, I3v2, P2mv3 |	64|
|I4v2, I5v2, I6v2 |	Max density bounded by vCPU usage@
|P3mv3, P4mv3, P5mv3 |	Max density bounded by vCPU usage|


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
