---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-04 00:05
definition: You can use a few different technologies to deploy your Azure Functions project code to Azure.
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows
url: undefined
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

The following table describes the available deployment methods for your code project.

|Deployment type|Methods|Best for...|
|---|---|---|
|Tools-based|• [Visual Studio Code publish](https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-vs-code#publish-to-azure)  <br>• [Visual Studio publish](https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-vs#publish-to-azure)  <br>• [Core Tools publish](https://learn.microsoft.com/en-us/azure/azure-functions/functions-run-local#publish)|Deployments during development and other improvised deployments. Deploying your code on-demand using [local development tools](https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-local#local-development-environments).|
|App Service-managed|• [Deployment Center (CI/CD)](https://learn.microsoft.com/en-us/azure/azure-functions/functions-continuous-deployment)  <br>• [Container deployments](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-custom-container#enable-continuous-deployment-to-azure)|Continuous deployment (CI/CD) from source control or from a container registry. Deployments are managed by the App Service platform (Kudu).|
|External pipelines|• [Azure Pipelines](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-azure-devops)  <br>• [GitHub Actions](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-github-actions)|Production pipelines that include validation, testing, and other actions that must be run as part of an automated deployment. Deployments are managed by the pipeline.|

|Deployment technology|Windows Consumption|Windows Premium|Windows Dedicated|Linux Consumption|Linux Premium|Linux Dedicated|
|---|---|---|---|---|---|---|
|[External package URL](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#external-package-url)1|✔|✔|✔|✔|✔|✔|
|[Zip deploy](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#zip-deploy)|✔|✔|✔|✔|✔|✔|
|[Docker container](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#docker-container)|||||✔|✔|
|[Source control](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#source-control)|✔|✔|✔||✔|✔|
|[Local Git](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#local-git)1|✔|✔|✔||✔|✔|
|[FTPS](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#ftps)1|✔|✔|✔||✔|✔|
|[In-portal editing](https://learn.microsoft.com/en-us/azure/azure-functions/functions-deployment-technologies?tabs=windows#portal-editing)2|✔|✔|✔|✔|✔|✔|