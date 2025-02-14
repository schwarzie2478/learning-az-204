---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2025-02-12 08:12
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`



> [!attention] 
> Make sure to work with the same version of Visual Studio/Sql Management Studio and localdb to avoid issues during development



There is a default instance you can point to

ConnectionString (localdb)\MSSqlServer
# Create own [[localdb]]

sqllocaldb create 'name'

# query existing instances

sqllocaldb info

