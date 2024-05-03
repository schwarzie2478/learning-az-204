---
dg-publish: true
tags:
  - concept/SRE/cloud/azure
definition: Regions covered by Azure datacenters locally
aliases:
  - Azure Region
creation_date: 2024-05-02 22:00
modification_date: 2024-05-02 22:05
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

