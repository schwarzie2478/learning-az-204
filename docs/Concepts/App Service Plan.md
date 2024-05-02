---
aliases:
  - Server Farm
tags:
  - concept/SRE/cloud/azure 
definition: This defines the SKU on which the apps will be running, each plan belongs to one region
ms-learn-url: https://learn.microsoft.com/en-us/azure/app-service/overview-hosting-plans
---
Each service plan has an admin site (F.e. https://mysite.scm.azurewebsites.net).
powered by [[Kudu]].


#### App Service Plan SKU 

| App Service Plan SKU | Max Apps |
|--------------------- | --------- |
| B1, S1, P1v2, I1v1   | 8        |
|B2, S2, P2v2, I2v1	|16|
|B3, S3, P3v2, I3v1	| 32 |
|P0v3	| 8|
|P1v3, I1v2	| 16|
|P2v3, I2v2, P1mv3 |	32|
|P3v3, I3v2, P2mv3 |	64|
|I4v2, I5v2, I6v2 |	Max density bounded by vCPU usage@
|P3mv3, P4mv3, P5mv3 |	Max density bounded by vCPU usage|

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



