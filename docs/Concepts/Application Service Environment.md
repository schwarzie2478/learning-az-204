---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
definition: An App Service Environment (ASE) is a single-tenant deployment of the Azure App Service that runs in your virtual network.
type: term
aliases:
  - ASE
ms-learn-url: https://learn.microsoft.com/en-us/azure/app-service/networking-features#app-service-environment
creation_date: 2024-05-02 22:00

---
An App Service Environment is an [[Azure App Service]] feature that provides a fully isolated and dedicated environment for running App Service apps securely at high scale.


- It's for a single-tenant, you get your own hardware
- a specific [[Azure App Service]] deployment
-  you don't need to use [[virtual network integration]] because the ASE is already in your [[Azure Virtual Network]]

To access Azure storage or other services: enable [[service endpoints]] on the ASE subnet.
