---
tags:
  - concept/SRE/cloud/azure 
definition: Regions covered by Azure datacenters locally
aliases:
  - Azure Region
---

## How to get all possible locations for your subscription
[[Azure CLI]]:

```
az account list-locations -o table
```
[[AZ Powershell Module]]
```powershell
Get-AzLocation | select Location
```

[[Azure Resource Provider]] Namespace : Microsoft.Storage

Output: [[Azure Location Example Listing]]
