---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
  - best-practices
  - concept/SRE/cloud
  - concept/SRE/cloud/azure
ms-learn-url: https://learn.microsoft.com/en-us/azure/well-architected
creation_date: 2024-05-02 18:40

---
## Pillars

Reference: https://learn.microsoft.com/en-us/azure/well-architected/pillars

| Pillar                                                                                                                   | Workload concern                                  | Apply the principles                                                                                                                                                                                                | Strike a balance                                                                                       |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------ |
| [[Reliability design patterns]] [**Reliability**](https://learn.microsoft.com/en-us/azure/well-architected/reliability/) | Resiliency, availability, recovery                | Design for business requirements, resilience, recovery, and operations, while keeping it simple.  <br>[Design principles](https://learn.microsoft.com/en-us/azure/well-architected/reliability/principles)          | [Tradeoffs](https://learn.microsoft.com/en-us/azure/well-architected/reliability/tradeoffs)            |
| [**Security**](https://learn.microsoft.com/en-us/azure/well-architected/security/)                                       | Data protection, threat detection, and mitigation | Protect confidentiality, integrity, and availability.  <br>[Design principles](https://learn.microsoft.com/en-us/azure/well-architected/security/principles)                                                        | [Tradeoffs](https://learn.microsoft.com/en-us/azure/well-architected/security/tradeoffs)               |
| [**Cost Optimization**](https://learn.microsoft.com/en-us/azure/well-architected/cost-optimization/)                     | Cost modeling, budgets, reduce waste              | Optimize on usage and rate utilization while keeping a cost-efficient mindset.  <br>[Design principles](https://learn.microsoft.com/en-us/azure/well-architected/cost-optimization/principles)                      | [Tradeoffs](https://learn.microsoft.com/en-us/azure/well-architected/cost-optimization/tradeoffs)      |
| [**Operational Excellence**](https://learn.microsoft.com/en-us/azure/well-architected/operational-excellence/)           | Holistic observability, DevOps practices          | Streamline operations with standards, comprehensive monitoring, and safe deployment practices.  <br>[Design principles](https://learn.microsoft.com/en-us/azure/well-architected/operational-excellence/principles) | [Tradeoffs](https://learn.microsoft.com/en-us/azure/well-architected/operational-excellence/tradeoffs) |
| [**Performance Efficiency**](https://learn.microsoft.com/en-us/azure/well-architected/performance-efficiency/)           | Scalability, load testing                         | Scale horizontally, test early and often, and monitor the health of the solution.  <br>[Design principles](https://learn.microsoft.com/en-us/azure/well-architected/performance-efficiency/principles)              | [Tradeoffs](https://learn.microsoft.com/en-us/azure/well-architected/performance-efficiency/tradeoffs) |

## Ten Design Principles

Reference: https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/

- **[Design for self healing](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/self-healing)**. In a distributed system, failures happen. Design your application to be self healing when failures occur.
- **[Make all things redundant](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/redundancy)**. Build redundancy into your application, to avoid having single points of failure.
- **[Minimize coordination](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/minimize-coordination)**. Minimize coordination between application services to achieve scalability.
- **[Design to scale out](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/scale-out)**. Design your application so that it can scale horizontally, adding or removing new instances as demand requires.
- **[Partition around limits](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/partition)**. Use partitioning to work around database, network, and compute limits.
- **[Design for operations](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/design-for-operations)**. Design your application so that the operations team has the tools they need.
- **[Use managed services](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/managed-services)**. When possible, use platform as a service (PaaS) rather than infrastructure as a service (IaaS).
- **[Use an identity service](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/identity)**. Use an identity as a service (IDaaS) platform instead of building or operating your own.
- **[Design for evolution](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/design-for-evolution)**. All successful applications change over time. An evolutionary design is key for continuous innovation.
- **[Build for the needs of business](https://learn.microsoft.com/en-us/azure/architecture/guide/design-principles/build-for-business)**. Every design decision must be justified by a business requirement.