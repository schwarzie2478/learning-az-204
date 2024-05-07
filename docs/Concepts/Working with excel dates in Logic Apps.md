---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 16:15
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

## Problem

If you want to read from an excel cell with date formatting,
you need to convert it first to be able to work with it.

in Excel it is an integer!

## Solution

### From date to excel date

```javascript
add(div(sub(ticks(utcNow()),ticks('1900-01-01T00:00:00Z')),864000000000),2)
```

### Compare with date 

Is the date more then 14 days in the past?

```javascript
int(items('actionname')?['fieldname']) 
```
	is less then
```javascript
add(div(sub(ticks(addDays(utcNow(),-14)),ticks('1900-01-01T00:00:00Z')),864000000000),2)
```
