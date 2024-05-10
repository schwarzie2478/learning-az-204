---
status: planted
dg-publish: true
tags:
  - concept/SRE/database
creation_date: 2024-05-08 11:14
definition: Use a (single) database that is shared by multiple services. Each service freely accesses data owned by other services using local ACID transactions.
ms-learn-url: undefined
url: https://microservices.io/patterns/data/shared-database.html
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
Use a (single) database that is shared by multiple services. Each service freely accesses data owned by other services using local [[Atomicity Consistency Isolation and Durability|ACID]] transactions.