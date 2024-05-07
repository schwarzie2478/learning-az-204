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
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

Code: [[Azure Function Scenarios]]
Deployment: [[Azure Functions Deployement]]

Azure Functions supports [[Azure Function triggers|triggers]], which are ways to start execution of your code, and [[Azure Function Bindings|bindings]], which are ways to simplify coding for input and output data. There are other integration and automation services in Azure and they all can solve integration problems and automate business processes. They can all define input, actions, conditions, and output.

## Difference with [[Azure Logic Apps]]

|                   | Azure Functions                                                       | Logic Apps                                                                                             |
| ----------------- | --------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------ |
| Development       | Code-first (imperative)                                               | Designer-first (declarative)                                                                           |
| Connectivity      | About a dozen built-in binding types, write code for custom bindings  | Large collection of connectors, Enterprise Integration Pack for B2B scenarios, build custom connectors |
| Actions           | Each activity is an Azure function; write code for activity functions | Large collection of ready-made actions                                                                 |
| Monitoring        | Azure Application Insights                                            | Azure portal, Azure Monitor logs                                                                       |
| Management        | REST API, Visual Studio                                               | Azure portal, REST API, PowerShell, Visual Studio                                                      |
| Execution context | Runs in Azure, or locally                                             | Runs in Azure, locally, or on premises                                                                 |
## Difference with [[Azure App Service WebJobs]]

> [!info]
> Azure Functions is built on the WebJobs SDK, so it shares many of the same event triggers and connections to other Azure services.

| |Functions|WebJobs with WebJobs SDK|
|---|---|---|
|Serverless app model with automatic scaling|Yes|No|
|Develop and test in browser|Yes|No|
|Pay-per-use pricing|Yes|No|
|Integration with Logic Apps|Yes|No|
|Trigger events|Timer  <br>Azure Storage queues and blobs  <br>Azure Service Bus queues and topics  <br>Azure Cosmos DB  <br>Azure Event Hubs  <br>HTTP/WebHook (GitHub  <br>Slack)  <br>Azure Event Grid|Timer  <br>Azure Storage queues and blobs  <br>Azure Service Bus queues and topics  <br>Azure Cosmos DB  <br>Azure Event Hubs  <br>File system|
## Hosting Plans

Reference: [MS Learn](https://learn.microsoft.com/en-us/azure/azure-functions/dedicated-plan)

| Plan                 | Benefits                                                                                                                                                                                                                                    |
| -------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Consumption plan** | This is the default hosting plan. It scales automatically and you only pay for compute resources when your functions are running. Instances of the Functions host are dynamically added and removed based on the number of incoming events. |
| **Premium plan**     | Automatically scales based on demand using pre-warmed workers, which run applications with no delay after being idle, runs on more powerful instances, and connects to virtual networks.                                                    |
| **Dedicated plan**   | Run your functions within an App Service plan at regular App Service plan rates. Best for long-running scenarios where [[Azure Durable Functions]] can't be used.                                                                           |

> [!important] 
> Free and Shared tier App Service plans aren't supported by Azure Functions. For a lower-cost option hosting your function executions, you should instead consider the [Consumption plan](https://learn.microsoft.com/en-us/azure/azure-functions/consumption-plan), where you are billed based on function executions.

![[App Service Auto Scaling#^580ed5]]


  There are two other hosting options, which provide the ==highest amount of control and isolation== in which to run your function apps.

| Hosting option                                                                                                                                                                                                                             | Details                                                                                                                                                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **[[Application Service Environment\|ASE]]**                                                                                                                                                                                               | [App Service Environment (ASE)](https://learn.microsoft.com/en-us/azure/app-service/environment/intro) is an App Service feature that provides a fully isolated and dedicated environment for securely running App Service apps at high scale. |
| [[Azure Functions on Kubernetes]] ([Direct](https://learn.microsoft.com/en-us/azure/azure-functions/functions-kubernetes-keda) or [Azure Arc](https://learn.microsoft.com/en-us/azure/app-service/overview-arc-integration) [[Azure Arc]]) | Kubernetes provides a fully isolated and dedicated environment running on top of the Kubernetes platform.                                                                                                                                      |
## Function app timeout duration

> [!NOTE]
> The `functionTimeout` property in the _host.json_ project file specifies the timeout duration for functions in a function app.
> 


| Plan             | Default | Maximum   |
| ---------------- | ------- | --------- |
| Consumption plan | 5       | 10        |
| Premium plan     | 30      | Unlimited |
| Dedicated plan   | 30      | Unlimited |
## Storage account requirements

On any plan, a function app requires a general [[Azure Storage Account]] , which supports Azure Blob, Queue, Files, and Table storage. This is because Functions rely on Azure Storage for operations such as managing triggers and logging function executions, but some storage accounts don't support queues and tables.

#### Always On

Must be enabled in the App Service Plan.
Otherwise the functions could go idle and stop, only a HttpTrigger can restart it again then.



> [!info] 
>  The Consumption plan is the fully _serverless_ hosting option for Azure Functions.

#### Always On

> [!Info]
> In Consumption Plan always on is always enabled!