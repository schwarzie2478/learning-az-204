---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-16 11:25
definition: Virtual Network integration for an Azure service enables you to lock down access to the service to only your virtual network infrastructure.
ms-learn-url: https://learn.microsoft.com/en-us/azure/virtual-network/vnet-integration-for-azure-services
url: undefined
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`

Virtual network integration provides Azure services the benefits of network isolation with one or more of the following methods:

- [Deploying dedicated instances of the service into a virtual network](https://learn.microsoft.com/en-us/azure/virtual-network/virtual-network-for-azure-services). The services can then be privately accessed within the virtual network and from on-premises networks.
    
- Using [Private Endpoint](https://learn.microsoft.com/en-us/azure/private-link/private-endpoint-overview) that connects you privately and securely to a service powered by [Azure Private Link](https://learn.microsoft.com/en-us/azure/private-link/private-link-overview). Private Endpoint uses a private IP address from your virtual network, effectively bringing the service into your virtual network.
    
- Accessing the service using public endpoints by extending a virtual network to the service, through [service endpoints](https://learn.microsoft.com/en-us/azure/virtual-network/virtual-network-service-endpoints-overview). Service endpoints allow service resources to be secured to the virtual network.
    
- Using [service tags](https://learn.microsoft.com/en-us/azure/virtual-network/service-tags-overview) to allow or deny traffic to your Azure resources to and from public IP endpoints.