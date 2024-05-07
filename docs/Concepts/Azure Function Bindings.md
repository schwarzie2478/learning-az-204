---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 15:23
definition: The bindings property is where you configure both triggers and bindings.
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

Every binding requires the following settings

| Property    | Types  | Comments                                                                                                                             |
| ----------- | ------ | ------------------------------------------------------------------------------------------------------------------------------------ |
| `type`      | string | Name of binding. For example, [[queueTrigger]].                                                                                      |
| `direction` | string | Indicates whether the binding is for receiving data into the function or sending data from the function. For example, `in` or `out`. |
| `name`      | string | The name that is used for the bound data in the function. For example, `myQueue`.                                                    |
