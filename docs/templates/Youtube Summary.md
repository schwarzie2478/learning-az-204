---
status: seedling
dg-publish: true
tags:
  - unsorted
  - content/video/youtube
creation_date: <% tp.file.creation_date() %>
definition: undefined
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=SkMQStnqCZ0
author: unspecified
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |



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