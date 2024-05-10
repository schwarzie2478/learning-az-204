---
status: planted
dg-publish: true
tags:
  - tool/vscode/tips
creation_date: 2024-05-10 12:07
definition: How to replace the timespace with formatted section for playback purposes.
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
Using [[Regular Expression]] in [[Visual Studio Code]]

input:  02:45  , 1:14:45
desired output:
```markdown
	```timestamp
	 02:45
```

regex :  ^ ((\d{1,2}:)+\d\d$)
replace: ^ ((\d{1,2}:)+\d\d$)

When already inside a quote:
regex :  ^> ((\d{1,2}:)+\d\d$)
replace: ^> ((\d{1,2}:)+\d\d$)