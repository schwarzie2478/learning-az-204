---
status: seedling
dg-publish: true
tags:
  - unsorted
  - concept/SRE/cloud/azure
creation_date: 2024-05-05 08:18
definition: The Azure Relay service enables you to securely expose services that run in your corporate network to the public cloud.
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-relay/
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
It supersedes the former, equally named _BizTalk Services_ feature that was built on a proprietary protocol foundation.

The relay service supports the following scenarios between on-premises services and applications running in the cloud or in another on-premises environment.

- Traditional one-way, request/response, and peer-to-peer communication
- Event distribution at internet-scope to enable publish/subscribe scenarios
- Bi-directional and unbuffered socket communication across network boundaries
