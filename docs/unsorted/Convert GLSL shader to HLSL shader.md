---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-24 15:18
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`


Now the conversion is mostly straight forward process.  
I have to convert:

vec<X> to float<x>  
And mix -> lerp  
mat<n> to float<n>x<n>  
fract -> frac  
mod -> fmod