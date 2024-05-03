---
dg-publish: true
tags:
  - review
  - concept/SRE/cloud/azure
ms-learn-url: https://learn.microsoft.com/en-us/azure/well-architected/reliability/principles
creation_date: 2024-05-02 11:46
modification_date: 2024-05-02 23:11
---
[[Reliability]]

## [Design for business requirements](https://learn.microsoft.com/en-us/azure/well-architected/reliability/principles#design-for-business-requirements)
* Quantify Success by setting targets of indicator on individual components
* Understand platform commitments. **Consider the limits, quotas, regions, and capacity constraints** for services.
* **Determine dependencies** and their effect on resiliency.
## [Design for resilience](https://learn.microsoft.com/en-us/azure/well-architected/reliability/principles#design-for-resilience)
* **Distinguish components that are on the critical path** from those that can function in a degraded state.
* **Identify potential failure points in the system**, especially for the critical components, and determine the effect on user flows.
* **Build self-preservation capabilities** by using design patterns correctly and modularizing the design to isolate faults.
* **Add the capability to scale out the critical components** (application and infrastructure) by considering the capacity constraints of services in the supported regions.
* **Build redundancy in layers and resiliency on various application tiers.**
* **Overprovision to immediately mitigate individual failure** of redundant instances and to buffer against runaway resource consumption.
## [Design for recovery](https://learn.microsoft.com/en-us/azure/well-architected/reliability/principles#design-for-recovery)
* **Have structured, tested, and documented recovery plans** that are aligned with the negotiated recovery targets.
* Ensure that you can **repair data** of all stateful components within your recovery targets.
* Implement **automated self-healing capabilities** in the design.
* Replace stateless components with **[[Immutable and ephemeral infrastructure]]**.
## [Design for operations](https://learn.microsoft.com/en-us/azure/well-architected/reliability/principles#design-for-operations)
* **Build observable systems** that can correlate telemetry.
* **Predict potential malfunctions and anomalous behavior.** Make active reliability failures visible by using prioritized and actionable alerts.
* **Simulate failures** and run tests in production and pre-production environments. ([[Chaos Engineering]])

Part of [[Microsoft Azure Well-Architected Framework#Pillars|Microsoft Azure Well-Architected Framework]]
Part of [[Software Engineering Patterns]]
