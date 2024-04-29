---
aliases:
  - Server Farm
tags:
  - azure
definition: This defines the SKU on which the apps will be running, each plan belongs to one region
ms-learn-url: https://learn.microsoft.com/en-us/azure/app-service/overview-hosting-plans
---
Each service plan has an admin site (F.e. https://mysite.scm.azurewebsites.net).
powered by [[Kudu]].


#### SKU and Size


F: Free 
B: Basic/Baseline
D: development
S: Standard
P: Premium

P0 1 Core
P1 2 Core

P3  4-1 Memory-to-Core resulting in 8 core to 32Gb
P3m 8-1 Memory-to-Core resulting in 8 core to 64Gb

v3: currently most modern machine configuration
You must migrate to App Service Environment v3 before August 31, 2024 



