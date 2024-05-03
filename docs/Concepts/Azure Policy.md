---
dg-publish: true
tags:
  - concept/SRE/cloud/azure
definition: Azure Policy helps to enforce organizational standards and to assess compliance at-scale.Azure Policy evaluates resources and actions in Azure by comparing the properties of those resources to business rules.
ms-learn-url: https://learn.microsoft.com/en-us/azure/governance/policy/overview
creation_date: 2024-05-02 22:00
modification_date: 2024-05-02 22:05
---


Used by [[Azure Role Based Access Control]]

[[Policy Definition|Policy definitions]] are combined in [[Policy Initiative|policy initiatives]] a.k.a. [[Policy Set|policy sets]].
Once defined they are assigned to a scope:
- [[Azure Management groups]]
- [[Azure Resource Group]]
- [[Azure Subscription]]

Azure Policy has several permissions, known as operations, in two [[Azure Resource Provider|Resource Providers]]:
- [Microsoft.Authorization](https://learn.microsoft.com/en-us/azure/role-based-access-control/resource-provider-operations#microsoftauthorization)
- [Microsoft.PolicyInsights](https://learn.microsoft.com/en-us/azure/role-based-access-control/resource-provider-operations#microsoftpolicyinsights)
