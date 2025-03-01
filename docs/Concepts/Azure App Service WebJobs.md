---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
ms-learn-url: https://learn.microsoft.com/en-us/azure/architecture/best-practices/background-jobs#azure-web-apps-and-webjobs
creation_date: 2024-05-02 22:00
definition: You can use Azure WebJobs to execute custom jobs as background tasks within an Azure Web App.
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

Uses  [[Azure Webjob SDK]]
Similar to [[Azure Functions]] but,

## WebJobs are a better solution when:

- You want the code to be a part of an existing [[Azure Web App]] and to be managed as part of that application, for example in the same [[Azure DevOps]] environment.
- You need close control over the object that listens for events that trigger the code.

![[Azure Functions#Difference with Azure App Service WebJobs]] 

> [!tip]
> To minimize the impact of jobs on the performance of the web app, consider creating an empty [[Azure Web App]] instance in a new App Service plan to host long-running or resource-intensive WebJobs.
> 

## Configuring
- Run on demand
- Run on shedule
- Run continuously


