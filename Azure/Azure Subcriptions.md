---
tags:
  - azure
type: term
definition: Defines the SKU on which the apps will be running, each plan belongs to one region
---

Current Subscription:
$sub = Get-AzContext | %{ $_.Subscription} 

Organise your subscriptions by assign access with roles

RBAC + policies


---
ms-learn-url: (https://learn.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/organize-subscriptions)
---

Elevated Access: needed for restoring access to lost user resource groups

How does elevated access work?
Microsoft Entra ID and Azure resources are secured independently from one another. 
That is, Microsoft Entra role assignments do not grant access to Azure resources, and Azure role assignments do not grant access to Microsoft Entra

Request in portal: Microsoft Entra ID -> Properties -> Access Management for Azure Resources: Set to Yes

Result :  User Access Administrator role in Azure RBAC