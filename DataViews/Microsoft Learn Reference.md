```dataview
TABLE ms-learn-url
FROM #azure 
SORT file.name ASC
WHERE ms-learn-url != null
```