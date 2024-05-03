---
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-03 23:37
definition: When you create a function app in Azure, you must choose a hosting plan for your app.
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-functions/functions-scale
url: undefined
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
There are three basic Azure Functions hosting plans provided by Azure Functions:
- [[Azure Functions Consumption plan hosting]] [Consumption plan](https://learn.microsoft.com/en-us/azure/azure-functions/consumption-plan)
- [[Azure Functions Premium plan]] [Premium plan](https://learn.microsoft.com/en-us/azure/azure-functions/functions-premium-plan)
- [[Dedicated hosting plans for Azure Functions]][Dedicated (App Service) plan](https://learn.microsoft.com/en-us/azure/azure-functions/dedicated-plan)


In addition to Azure Functions hosting, you can also host containerized function apps in containers that can be deployed to [[Kubernetes]] clusters or to [[Azure Container Apps]]
