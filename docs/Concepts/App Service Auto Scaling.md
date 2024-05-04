---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-03 18:30
definition: Automatic scaling is a new scale-out option that automatically handles scaling decisions for your web apps and App Service Plans.
ms-learn-url: https://learn.microsoft.com/en-us/azure/app-service/manage-automatic-scaling?tabs=azure-portal
---

|   MetaData |                                       |
| ---------- | ------------------------------------------ |
| Definition | `VIEW[{definition}][text(renderMarkdown)]` |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]` |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |




Different from previous: [[Azure autoscale]].
You'll find more on this capability in the [automatic scaling](https://learn.microsoft.com/en-us/azure/app-service/manage-automatic-scaling) article.


### Scaling Options for [[App Service Plan]]
Free: No scaling
Dev: No
Basic: Manual scaling for this tier and higher
Standard(legacy): [[Azure autoscale|autoscale]]
Premium: Automatic Scaling

### Scaling Configuration

You enable automatic scaling for an App Service Plan and configure a range of instances for each of the web apps.

#### Max Burst
**Maximum burst** is the highest number of instances that your App Service Plan can increase to based on incoming HTTP requests.
Premium tier -> can scale up to 30 instances

With [[Azure CLI|az]]:
```shell
az appservice plan update --name <APP_SERVICE_PLAN> --resource-group <RESOURCE_GROUP> --elastic-scale true --max-elastic-worker-count <YOUR_MAX_BURST>
```

#### Minimal instances
**Always ready instances** is an app-level setting to specify the minimum number of instances.

```shell
az webapp update --resource-group <RESOURCE_GROUP> --name <APP_NAME> --minimum-elastic-instance-count <ALWAYS_READY_COUNT>
```
## Does automatic scaling support [[Azure Functions]] apps?

> [!caution]  
> Automatic Scaling is disabled when App Service web apps and Azure Function apps are in the same App Service Plan.

^580ed5

No, you can only have Azure App Service web apps in the App Service Plan where you wish to enable automatic scaling. For Functions, it's recommended to use the [[Azure Functions Premium plan]] instead.