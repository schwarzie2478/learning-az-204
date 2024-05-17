---
status: planted
dg-publish: true
tags:
  - code/dotNet/azure
creation_date: 2024-05-17 11:15
definition: Provides a default TokenCredential authentication flow for applications that will be deployed to Azure.
ms-learn-url: https://learn.microsoft.com/en-us/dotnet/api/azure.identity.defaultazurecredential?view=azure-dotnet
url: https://learn.microsoft.com/en-us/dotnet/api/azure.identity.defaultazurecredential?view=azure-dotnet
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`


By itself it can't provide a valid credential but it tries with different credential types to figure out the identity to be used.

First the environment variables are checked for some keys  like

Then other places are evaluated:
- Workload Id  used for workloads deployed for [[Kubernetes]]
- [[Service Principle|Mananged Identity]]
- logins from tools like VS [[Visual Studio Code]], [[Azure CLI]] [[AZ Powershell Module]] [[Azure Developer CLI]] 
- If all else fails, you can enable an interactive login to open an browser to let a person login, but by default this is disabled.

