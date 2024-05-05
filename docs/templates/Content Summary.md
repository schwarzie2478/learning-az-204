---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: <% tp.file.creation_date() %>
definition: undefined
ms-learn-url: undefined
url: undefined
---

| MetaData   |                                            |
| ---------- | ------------------------------------------ |
| Definition | `VIEW[{definition}][text(renderMarkdown)]` |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`        |

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