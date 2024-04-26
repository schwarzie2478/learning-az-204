---
tags:
  - azure
type: term
definition: Defines the SKU on which the apps will be running, each plan belongs to one region
---

## How to get all possible locations for your subscription

Powershell
```powershell
Get-AzLocation | select Location
```

[[Azure Resource Provider]] Namespace : Microsoft.Storage