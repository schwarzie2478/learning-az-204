```dataview
TABLE "TODO"
FROM #review 
SORT file.name ASC
```

```dataview
TABLE "Undefined"
FROM #azure 
where definition = "undefined"
```