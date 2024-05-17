---
status: planted
dg-publish: true
tags:
  - study/AZ-204
creation_date: 2024-05-16 15:02
definition: Modify C# Application to Use Storage Queue Instead of File System
ms-learn-url: undefined
url: https://cbtw.udemy.com/labs/modify-c-application-to-use-storage-queue-instead-of-file-system/overview/
aliases:
---

|  |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`

We create a [[Azure Storage Account]] in the desired resource group
We create a [[Azure Storage queue]] to write messages to
We configure the app with the code to use  ( [[Azure.Storage.Queues.QueueClient|QueueClient]] with [[Azure Storage Account connectionstring]]
)