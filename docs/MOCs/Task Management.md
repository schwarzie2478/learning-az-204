---
status: signpost
dg-publish: true
tags:
  - landingpage
creation_date: 2024-05-04 14:43
definition: Simple view of all open tasks
ms-learn-url: undefined
url: undefined
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
```dataview
task
from -"templates"
WHERE !completed
```
