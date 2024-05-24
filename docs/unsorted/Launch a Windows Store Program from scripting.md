---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-24 11:58
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


- Press Win+R
- enter shell:AppsFolder
- search for the application you wish to launch
- make a shortcut for it in an desired location
- refer to the shortcut in your script

Example with powershell:
```powershell
invoke-item 'Internet Explorer.lnk'
```
