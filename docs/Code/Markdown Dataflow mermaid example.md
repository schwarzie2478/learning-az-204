---
status: planted
dg-publish: true
tags:
  - "#code/markdown"
creation_date: 2024-05-24 00:17
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


```mermaid
graph LR
  User[User] --> createProject[Create Project]
  User --> assignTask[Assign Task]
  User --> trackProgress[Track Progress]
  create-project --> Project[Project]
  assignTask --> Task[Task]
  trackProgress --> Progress[Progress]
```

