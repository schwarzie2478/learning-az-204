---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
  - review
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-functions/functions-overview?pivots=programming-language-csharp
definition: Azure Functions is a serverless solution that allows you to write less code, maintain less infrastructure, and save on costs
creation_date: 2024-05-02 18:40

---
Code: [[Azure Function Scenarios]]
Deployment: [[Azure Functions Deployement]]
## Hosting Plans

Reference: [MS Learn](https://learn.microsoft.com/en-us/azure/azure-functions/dedicated-plan)


> [!important] 
> Free and Shared tier App Service plans aren't supported by Azure Functions. For a lower-cost option hosting your function executions, you should instead consider the [Consumption plan](https://learn.microsoft.com/en-us/azure/azure-functions/consumption-plan), where you are billed based on function executions.

![[App Service Auto Scaling#^580ed5]]
### App Service Hosting Plan
#### Always On

Must be enabled in the App Service Plan.
Otherwise the functions could go idle and stop, only a HttpTrigger can restart it again then.
### Azure Functions Consumption plan hosting


> [!info] 
>  The Consumption plan is the fully _serverless_ hosting option for Azure Functions.

#### Always On

In Consumption Plan always on is always enabled!