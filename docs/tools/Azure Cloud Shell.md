---
status: planted
dg-publish: true
definition: Azure Cloud Shell is an interactive, authenticated, browser-accessible terminal for managing Azure resources.
tags:
  - concept/SRE/cloud/azure
  - tool
ms-learn-url: https://learn.microsoft.com/en-us/azure/cloud-shell/overview
creation_date: 2024-05-02 22:00

---

> [!attention] 
> Accessing the Cloud Shell for the first time will create a resource group and an storage account. Although the usage of the shell is free, the storage underneath will incur some cost!

## How to remove the cloud base storage account:

Using Powershell:

```powershell
Remove-AzStorageAccount -ResourceGroupName "cloud-shell-storage-westeurope" -Name "csb1003bffd9fbbd5e0"
```
