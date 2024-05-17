---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
definition: An functional account credential to provide non-interactive access to resources.
ms-learn-url: (https://learn.microsoft.com/en-us/cli/azure/azure-cli-sp-tutorial-1?tabs=bash)
creation_date: 2024-05-02 22:00
aliases:
  - Mananged Identity
---

Often used in scripts

[[AZ Powershell Module]]:
![[AZ Powershell Module#^325307]]

[[Azure CLI]]

## Login
> [!example] 
> az login --service-principal -u  \< app-id\> -p \<password-or-cert\> --tenant \<tenant\>

Inside an azure service you can retrieve this identity with [[ManagedIdentityCredential]]  class.

## Retrieve credential(PS)

```powershell
Get-AzUserAssignedIdentity -Name az-204-operations -ResourceGroupName az204_prep -SubscriptionId 6e5b1a06-bb09-43e4-8f25-d787ea8e23af
```
