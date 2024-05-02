```dataview
TABLE definition, ms-learn-url 
FROM #azure 
SORT file.name ASC
WHERE definition != null or ms-learn-url != null
```