---
tags:
  - azure
---
## Create Resoure group

### Via Portal

### Via ARM

{
    "$schema": "https://schema.management.azure.com/schemas/2018-05-01/subscriptionDeploymentTemplate.json#",
    "contentVersion": "1.0.0.1",
    "parameters": {
        "rgName": {
            "type": "string"
        },
        "rgLocation": {
            "type": "string"
        },
        "tags": {
            "type": "object",
            "defaultValue": {}
        }
    },
    "variables": {},
    "resources": [
        {
            "type": "Microsoft.Resources/resourceGroups",
            "apiVersion": "2018-05-01",
            "location": "[parameters('rgLocation')]",
            "name": "[parameters('rgName')]",
            "properties": {},
            "tags": "[parameters('tags')]"
        }
    ],
    "outputs": {}
}

{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentParameters.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "rgName": {
            "value": "az204_prep"
        },
        "rgLocation": {
            "value": "westeurope"
        },
        "tags": {
            "value": {
                "environment": "development"
            }
        }
    }
}

### Via Power shell Script

Ref: [Manage Resouces](https://learn.microsoft.com/en-us/azure/azure-resource-manager/management/manage-resources-powershell)


