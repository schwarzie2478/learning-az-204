---
status: signpost
dg-publish: true
tags:
  - landingpage
creation_date: 2024-05-04 10:10
definition: Place to meditate and plant some seeds
ms-learn-url: undefined
url: undefined
---
| MetaData   |                                            |
| ---------- | ------------------------------------------ |
| Definition | `VIEW[{definition}][text(renderMarkdown)]` |
- [ ] Do some [[Daily Gardening|gardening]] 🔽 🔁 every day when done 🛫 2024-05-08
- [x] Do some [[Daily Gardening|gardening]] 🔽 🔁 every day when done 🛫 2024-05-07 ✅ 2024-05-07
- [x] Do some [[Daily Gardening|gardening]] 🔽 🔁 every day when done 🛫 2024-05-06 ✅ 2024-05-06
- [x] Do some [[Daily Gardening|gardening]] 🔽 🔁 every day when done 🛫 2024-05-05 ✅ 2024-05-05
- [x] Do some gardening 🔽 🔁 every day when done 🛫 2024-05-04 ✅ 2024-05-04
## seedbox

```dataviewjs
const tableHeadings = ["Name", "status"];
const fileQuery = '-"templates"';
const limit = 150;
const sortBy = 'status';

const {fieldModifier: f} = this.app.plugins.plugins["metadata-menu"].api;

dv
    .table(tableHeadings,
    await Promise.all(dv.pages(fileQuery)
    .where(f => f.status == "seedling")
    .limit(limit).sort(k => k[sortBy], 'desc')
    .map(async p => [
        p.file.link,
        await f(dv, p, "status")
    ])
));

```



## Maturity Levels

The maturity level for each note is represented by plant icons of various growth.

### Seedling

Seedlings (![Maturity Level: 1|14](https://hermitage.utsob.me/img/tree-1.svg)) are thoughts barely started. Maybe Jotted down in haste or simply showed only a brief amount of what I thought about it by far.

### Sapling

Saplings (![Maturity Level: 2|14](https://hermitage.utsob.me/img/tree-2.svg)) have a substantial amount of content, but much work to be done. Coherence and patterns are just emerging in it.

### Tree

Trees (![Maturity Level: 3|14](https://hermitage.utsob.me/img/tree-3.svg)) are grown-up coherent pieces of thought/essay/expression that should not change much except for some editorial enhancements.

### Withered

Withered (![Maturity Level: withered|14](https://hermitage.utsob.me/img/withered.svg)) are the notes expressing outdated views (totally or partially) but kept for the historicity of our thoughts. For partially outdated notes, warnings will be placed wherever appropriate.

### Stone

Stones (![Maturity Level: stone|14](https://hermitage.utsob.me/img/stone.svg)) are notes exported/extracted from other mediums (e.g. Reading highlights and notes). Growth is irrelevant for these notes.

### Signpost

Signposts (![Maturity Level: signpost|14](https://hermitage.utsob.me/img/signpost.svg)) are notes that allow us to navigate easily (e.g. Collection of books or writings).