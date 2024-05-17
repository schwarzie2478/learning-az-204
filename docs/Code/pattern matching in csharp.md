---
status: planted
dg-publish: true
tags:
  - code/dotNET
creation_date: 2024-05-09 22:17
definition: Pattern matching is a technique where you test an expression to determine if it has certain characteristics.
ms-learn-url: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching
url: undefined
aliases:
---


|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`



## Example
```c#
public State PerformOperation(string command) =>
   command switch
   {
       "SystemTest" => RunDiagnostics(),
       "Start" => StartSystem(),
       "Stop" => StopSystem(),
       "Reset" => ResetToReady(),
       _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
   };
```
