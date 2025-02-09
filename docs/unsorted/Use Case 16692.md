---
status: seedling
dg-publish: true
tags: []
creation_date: 2025-02-06 16:11
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


[Product Backlog Item 16692](https://dev.azure.com/ibzfgovbe/SinglePermit/_workitems/edit/16692): Step 1A of the semantic validation: User can change identity data based on passport


What to do:
- Add pasport entity and fields for worker identity in domain ( worker is part of PermitRequestData)
- Add validate or update request of worker information in permit request


Questions:

- Land van afgifte, waar codetable stockeren 'single source of truth', masterdata a
-  vertalingen beheren, default translation api?
-  validatie fouten in api terug naar front-end ( vertaling?)
-  using translationstrings for other purposes
- Error handling API to front-end ( error details for validation)
- 


```c#
    public class AttachmentStatus : TranslatedString
    {
        public ICollection<Attachment> Attachments { get; set; } = null!;
    }
```

Putting actual objects into translationstrings:   no SOLID
