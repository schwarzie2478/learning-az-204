---
dg-publish: true
tags:
  - dailynotes
---

Tasks:
```tasks
due on or before today
not done
```

Modified Notes
```dataview
Table dateformat(file.mtime, "yyyy-MM-dd HH:mm") AS "Last Modified"
FROM "" AND -"Daily Notes"
WHERE file.mtime.day = this.file.day.day
AND file.mtime.month = this.file.day.month
and file.name != this.file.name
SORT file.mtime desc
```