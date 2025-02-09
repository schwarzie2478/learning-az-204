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

```mermaid

sequenceDiagram

    participant Alice

    participant John

  

    rect rgb(191, 223, 255)

    note right of Alice: Alice calls John.

    Alice->>+John: Hello John, how are you?

    rect rgb(200, 150, 255)

    Alice->>+John: John, can you hear me?

    John-->>-Alice: Hi Alice, I can hear you!

    end

    John-->>-Alice: I feel great!

    end

    Alice ->>+ John: Did you want to go to the game tonight?

    John -->>- Alice: Yeah! See you there.

```

  
  

```mermaid

graph LR

    fa:fa-check-->fab:fa-python

```
