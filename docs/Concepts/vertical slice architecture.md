---
status: planted
dg-publish: true
tags:
  - concept/SRE
creation_date: 2024-05-19 20:28
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


group everything concerning a bounded context in your domain together.

Inside the slice you can still follow the preferred way of organizing your code but nothing should be shared between the slices. ( don't start to couple what you have just torn apart)

examples to use inside the slice:
- [[Clean Architecture]]
- [[Domain Driven Design]]
- [[Data and Ports]]
- [[Hexagonal Architecture]]
