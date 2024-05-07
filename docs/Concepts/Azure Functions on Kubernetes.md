---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 17:13
definition: The Azure Functions runtime provides flexibility in hosting where and how you want. KEDA (Kubernetes-based Event Driven Autoscaling) pairs seamlessly with the Azure Functions runtime and tooling to provide event driven scale in Kubernetes.
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-functions/functions-kubernetes-keda
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!important]
> Running your containerized function apps on [[Kubernetes]], either by using [[Kubernetes Event-driven Autoscaling|KEDA]] or by direct deployment, is an open-source effort that you can use free of cost.

Containerized function app deployments to Azure Container Apps, which runs on managed Kubernetes clusters in Azure, is currently in preview. For more information, see [[Azure Container Apps hosting of Azure Functions]]
