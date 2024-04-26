---
definition: online console to manage your resource group
aliases:
  - console
tags:
  - azure
type: term
---

> [!attention] 
> Accessing the Cloud Shell for the first time will create a resource group and an storage account. Although the usage of the shell is free, the storage underneath will incur some cost!

## How to remove the cloud base storage account:

Using Powershell:

```powershell
Remove-AzStorageAccount -ResourceGroupName "cloud-shell-storage-westeurope" -Name "csb1003bffd9fbbd5e0"
```
