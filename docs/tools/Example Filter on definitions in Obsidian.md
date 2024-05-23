---
status: planted
tags:
  - tool/obsidian
creation_date: 2024-05-06 13:05
---


```dataviewjs
const tableHeadings = ["Name", "definition"];
const fileQuery = '-"templates"';
const limit = 150;
const sortBy = 'Name';

const {fieldModifier: f} = this.app.plugins.plugins["metadata-menu"].api;

dv
    .table(tableHeadings,
    await Promise.all(dv.pages(fileQuery)
	    .where(f => f.definition != null && f.definition.includes("["))
    .limit(limit).sort(k => k[sortBy], 'desc')
    .map(async p => [
        p.file.link,
        await f(dv, p, "definition")
    ])
));

```
