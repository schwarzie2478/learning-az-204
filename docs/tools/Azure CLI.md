---
status: planted
dg-publish: true
ms-learn-url: (https://learn.microsoft.com/en-us/cli/azure/)
tags:
  - concept/SRE/cloud/azure
  - tool
definition: Azure commanline tool to manage Azure resources
aliases:
  - az
creation_date: 2024-05-02 22:00

---


## Login

Basic login
    az login

On windows you can use the Web Broker

```
az config set core.enable_broker_on_windows=true
az account clear
az login
```

When no browser is availible or you don't want to use the browser, use device code flow
    az login --use-device-code
`
Account info
    az account show

## Example Create Virtual Machine

`az group create -name examplevmgroup -location eastus`

## Example Update Plan for Max Burst

![[App Service Auto Scaling#Setting Max Burst with Azure CLI az]]

## Example Update Plan for minimal instance
![[App Service Auto Scaling#Setting minimal instances with Azure CLI az]]


## Extra notes

### [[Azure CLI Extentions]]

### Azure CLI uses python packages for extentions

Ref: [link](https://github.com/Azure/azure-cli/tree/master)  
Notable python package wheel ( *.whl)

Format:
  chardet-3.0.4-py2.py3-none-any.whl  
You can break this down into its tags:

* chardet is the package name.
* 3.0.4 is the package version of chardet.
* py2.py3 is the Python tag, meaning the wheel supports Python 2 and 3 with any Python implementation.
* none is the ABI tag, meaning the ABI isn’t a factor. ABI stands for application binary interface.
* any is the platform. This wheel will work on virtually any platform.

Usage:  
```shell
az version  
az upgrade  
az extension update --name azure-devops --verbose
```
