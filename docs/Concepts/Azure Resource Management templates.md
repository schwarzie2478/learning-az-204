---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
type: term
creation_date: 2024-05-02 22:00

---

To learn about [[Azure Resource Manager]] templates (ARM templates), see the [ARM template overview](https://learn.microsoft.com/en-us/azure/azure-resource-manager/templates/overview). 

Deploy something with Powershell

New-AZResourceGroupDeployment -ResourceGroupName $rg -TemplateUri $TemplateUri 


## Template library

you can save an arm template for an resource to Azure Template library

Is called a template spec
Has versioning
belongs to a resourcegroup (take care not to delete this rg)
Doesn't save the parameters
