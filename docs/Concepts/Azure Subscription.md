---
tags:
  - concept/SRE/cloud/azure 
type: term
definition: Subscriptions are a unit of management, billing, and scale within Azure.
ms-learn-url: https://learn.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-subscriptions
---
Capture subscription requirements and design target subscriptions based on critical factors, which are based on:
- environment type
- ownership and governance model
- organizational structure
- application portfolios

Organise your subscriptions by assign access with roles
[[Azure Role Based Access Control|RBAC]] + [[Azure Policy|policies]]



Current Subscription:
$sub = Get-AzContext | %{ $_.Subscription} 

Organise your subscriptions by assign access with roles
RBAC + policies


Elevated Access: needed for restoring access to lost user resource groups

How does elevated access work?
Microsoft Entra ID and Azure resources are secured independently from one another. 
That is, Microsoft Entra role assignments do not grant access to Azure resources, and Azure role assignments do not grant access to Microsoft Entra

Request in portal: Microsoft Entra ID -> Properties -> Access Management for Azure Resources: Set to Yes

Result :  User Access Administrator role in Azure RBAC