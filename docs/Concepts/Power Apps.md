---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 16:32
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |


## Sorting and filtering in a list

Tested on an BrowseGallery

### Add an control for the dropdown

If the field you are targeting is not a simpel value, you need to add a column with the value you want. How you get this value needs to be investigated more.

```javascript
Distinct(AddColumns('SharepointList',NewValue,'SpecialField'.Value),NewValue)
```

### We need to use the selected value as an filter for the list

```javascript
SortByColumns(
    Filter(
        AddColumns('SharepointList',NewValue,'SpecialField'.Value) ,
        NewValue = Dropdown1.SelectedText.Value
        ,
        StartsWith(
            Name.DisplayName,
            TextSearchBox1.Text
        )
    ),
    "Title",
    If(
        SortDescending1,
        SortOrder.Descending,
        SortOrder.Ascending
    )
)
```

