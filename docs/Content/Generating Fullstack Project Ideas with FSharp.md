---
status: seedling
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-06 14:53
definition: Generating Fullstack Project Ideas with F#
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=tpdgk9bnarM
author: HAMY LABS
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

[site](https://hamy.xyz/labs/fullstack-projects)
- [ ] Review Generating Fullstack Project Ideas with FSharp
## Video
`$= "Made by [[" + dv.current().author+"]]"`
`$= "![video](" + dv.current().url + ")"`

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