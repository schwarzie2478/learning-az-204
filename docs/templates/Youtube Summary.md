---
status: seedling
dg-publish: true
tags:
  - content/video/youtube
creation_date: <% tp.file.creation_date() %>
definition: <% title = tp.system.prompt("Paste the youtube title here") %>
ms-learn-url: undefined
url: <% tp.system.prompt("Paste the youtube url here") %>
author: <% tp.system.prompt("Paste the youtube creator here") %>
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [ ] Review <% title %>

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