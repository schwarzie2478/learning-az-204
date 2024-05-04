---
status: signpost
dg-publish: true
dg-home: true
AutoNoteMover: disable
creation_date: 2024-05-02 18:40
---

## Welcome to my knowledge vault!

[[Daily Gardening]]
[[Task Management]]

Pinned:

```dataviewjs
const tableHeadings = ["Name", "status"];
const fileQuery = '#pinned';
const limit = 10;
const sortBy = 'status';

const {fieldModifier: f} = this.app.plugins.plugins["metadata-menu"].api;

dv
    .table(tableHeadings,
    await Promise.all(dv.pages(fileQuery).limit(limit).sort(k => k[sortBy], 'desc')
    .map(async p => [
        p.file.link,
        await f(dv, p, "status")
    ])
));

```

Landing Pages:
```dataview
List 
From  #landingpage
```

