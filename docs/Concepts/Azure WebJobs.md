---
tags:
  - concept/SRE/cloud/azure
ms-learn-url: https://learn.microsoft.com/en-us/azure/architecture/best-practices/background-jobs#azure-web-apps-and-webjobs
---


Tip:
To minimize the impact of jobs on the performance of the web app, consider creating an empty Azure Web App instance in a new App Service plan to host long-running or resource-intensive WebJobs.