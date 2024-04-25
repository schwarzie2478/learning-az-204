# Azure Web App

Also known as App Service
## Requirements

To be able to deploy an WebApp,
You need an Subscription, ResourceGroup and an App Service Plan

## Creation Options

### Deployment options

Code (Github Actions)
Docker
Static Web App

### App Service Plan

service level agreements around the hosting of your applications

A.k.a server farm

#### SKU and Size

F: Free 
B: Basic
D: development
S: Standard
P: Premium



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


### Publishing from Visual Studio

use publish wizard

#### scm 

Every App Service has a site extension to allow for software configuration management ( SCM)

if your site is configured as  mysite.azurewebsites.net,  the scm is reachable at  mysite.scm.azurewebsites.net

### Deployment slots

Default only one slot -> production slot

If you want test deployment -> create additional slots ( staging f.e.)

later you can switch deployments into production  no downtime!
You can publish in production, but you can also swap slots

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
