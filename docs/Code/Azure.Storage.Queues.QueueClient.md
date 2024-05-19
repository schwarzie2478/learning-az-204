---
status: planted
dg-publish: true
tags:
  - code/dotNet/azure
creation_date: 2024-05-17 09:14
definition: A QueueClient represents a URI to the Azure Storage Queue service allowing you to manipulate a queue.
ms-learn-url: https://learn.microsoft.com/en-us/dotnet/api/azure.storage.queues.queueclient?view=azure-dotnet
url: undefined
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`

Part of [[Azure.Storage.Queue]]

Usage:

```C#
// Create a QueueClient that will authenticate through Active Directory
Uri queueUri = new Uri("https://MYSTORAGEACCOUNT.queue.core.windows.net/QUEUENAME");
QueueClient queue = new QueueClient(queueUri, new DefaultAzureCredential());
```

Uses [[DefaultAzureCredential]]
