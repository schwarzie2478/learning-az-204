---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-10 13:20
definition: Use Artificial Intelligence to Classify Space Rocks Learn with Dr G
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=XoHR4p8AO9o
author: Dr. Sara G 
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [ ] Review Use Artificial Intelligence to Classify Space Rocks Learn with Dr G

## Video
`$= "Made by [[" + dv.current().author+"]]"`
Open player in Obsidian:
```timestamp-url 
 https://www.youtube.com/watch?v=XoHR4p8AO9o
 ```

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