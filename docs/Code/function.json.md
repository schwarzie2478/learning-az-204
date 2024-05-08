---
status: planted
dg-publish: true
tags:
  - code/dotNet/azure
creation_date: 2024-05-07 21:01
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

The _function.json_ file defines
- the one function's trigger
- [[Azure Function Bindings]] 
- other configuration settings.

## Example

```
{
    "disabled":false,
    "bindings":[
        // ... bindings here
        {
            "type": "bindingType",
            "direction": "in",
            "name": "myParamName",
            // ... more depending on binding
        }
    ]
}
```