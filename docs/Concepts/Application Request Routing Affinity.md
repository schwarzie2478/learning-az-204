---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-03 23:06
definition: Where we are scaling the Website across multiple instances, the ARR Affinity cookie will be bound to a specific server.
ms-learn-url: undefined
url: undefined
aliases:
  - ARR afinity
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

[[Azure WebApp]] by default have ARR Affinity cookie enabled, this cookie pairs a client request to a specific server. However, Azure Web Apps is a stateless platform and, in an environment, where we are scaling the Website across multiple instances, the ARR Affinity cookie will be bound to a specific server. In case, the server is no longer in rotation, then all the requests corresponding to the ARR Affinity cookie will fail.

> [!important] 
> Disabling ARR cookies is a sustainable resolution for issues related to ARR Affinity cookies in scaled environments, where these cookies rely on the relationship with the worker machine they are paired with.