---
status: planted
dg-publish: true
tags:
  - content/book/programming
creation_date: 2024-05-08 19:05
definition: Books about high-performance software delivery DevOps Handbook + Team Topologies + Accelerate + Microservices Patterns
ms-learn-url: undefined
url: https://microservices.io/post/microservices/2020/01/07/books-about-high-performance-software-delivery.html
author: Kong
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [ ] Review Books about high-performance software delivery: DevOps Handbook + Team Topologies + Accelerate + Microservices Patterns


`$= "Made by [[" + dv.current().author+"]]"`

## Callouts View

```dataviewjs
const regex = new RegExp(">\\s\\[\\![a-z]*\\]\\s(.+?)(\\n>\\s.*?)*\\n", "gi")
let page = dv.current()
const content = await dv.io.load(page.file.path)
const rows = []
for(const callout of content.match(regex)|| [])
{
	rows.push(callout)
}
dv.list(rows)
```

## Transcription

Your notes go here