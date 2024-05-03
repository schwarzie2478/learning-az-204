---
dg-publish: true
dg-home: true
---

## Welcome to my knowledge vault!

Pinned:
```dataview
List 
From #pinned
```
Concepts:
```dataview
List 
From #concept/general or (#concept and #landingpage)
```

Other:
```dataview
List 
From  #landingpage
where !contains(tags, "concept") and file.name != "General Concepts"
```

