---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
definition: An Azure resource provider is a set of REST operations that enable functionality for a specific Azure service.
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-resource-manager/management/resource-providers-and-types
creation_date: 2024-05-02 22:00

---

> [!attention] 
> You must register Resource Provider for your subscription.

Some resource providers are registered by default. For a list of resource providers registered by default, see [Resource providers for Azure services](https://learn.microsoft.com/en-us/azure/azure-resource-manager/management/azure-services-resource-providers).

For example: 
* [[Microsoft.Compute]]: is the provider that takes care of the virtual machine resources and app services
* [[Microsoft.Storage]]: is the provider for storage accounts and such
- [Microsoft.Authorization](https://learn.microsoft.com/en-us/azure/role-based-access-control/resource-provider-operations#microsoftauthorization)
- [Microsoft.PolicyInsights](https://learn.microsoft.com/en-us/azure/role-based-access-control/resource-provider-operations#microsoftpolicyinsights)

[[Azure Resource Provider Example Listing]]
