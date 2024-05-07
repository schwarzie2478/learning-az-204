---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-07 13:00
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

Example of [[Regular Expression]] 
Regex Tester: https://regex101.com/r/vPo9Cs/1

Input:
```
- Create and manage container images for solutions

- Publish an image to Azure Container Registry
```
Regex:
```
(- C.*\n)\s*(?=\n-)
```

Replace 
```
$1
```

Expected result
```
- Create and manage container images for solutions
- Publish an image to Azure Container Registry
```

Actual Result
```
$1
```

