---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-05 08:14
definition: Hybrid Connections provides access from your app to a TCP endpoint and doesn't enable a new way to access your app.
ms-learn-url: https://learn.microsoft.com/en-us/azure/app-service/app-service-hybrid-connections
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
[[Hybrid Connections]] is both a service in Azure and a feature in Azure App Service. As a service, it has uses and capabilities beyond those that are used in App Service.

Hybrid Connections requires a relay agent to be deployed where it can reach both the desired endpoint and Azure.

To learn more about Hybrid Connections and their usage outside App Service, see [[Azure Relay Hybrid Connections]].

There are many benefits to the Hybrid Connections capability, including:

- Apps can access on-premises systems and services securely.
- The feature doesn't require an internet-accessible endpoint.
- It's quick and easy to set up. No gateways required.
- Each Hybrid Connection matches to a single host:port combination, helpful for security.
- It normally doesn't require firewall holes. The connections are all outbound over standard web ports.
- Because the feature is network level, it's agnostic to the language used by your app and the technology used by the endpoint.
- It can be used to provide access in multiple networks from a single app.
- Supported in GA for Windows apps and Linux apps. It isn't supported for Windows custom containers.

[](https://learn.microsoft.com/en-us/azure/app-service/app-service-hybrid-connections#things-you-cant-do-with-hybrid-connections)

### Things you can't do with Hybrid Connections

Things you can't do with Hybrid Connections include:

- Mount a drive.
- Use UDP.
- Access TCP-based services that use dynamic ports, such as [[FTP Passive Mode]] or Extended Passive Mode.
- Support LDAP, because it can require UDP.
- Support Active Directory, because you can't domain join an App Service worker.