---
status: planted
dg-publish: true
tags:
  - concept/SRE
creation_date: 2024-05-06 07:11
definition: The mark-and-Sweep garbage collection algorithm is an indirect collection algorithm, which means it does not have any direct information about the garbage, instead, it identifies the garbage by eliminating everything LIVE.
ms-learn-url: https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
Every object that could be traced is marked as live and at the end of tracing the ones without the mark are removed (swept) from the memory and it gets compacted. This is called a simple **mark and sweep algorithm**.

![[Animation_of_the_Naive_Mark_and_Sweep_Garbage_Collector_Algorithm.gif]]