---
status: planted
dg-publish: true
tags:
  - code/dotNet/azure
creation_date: 2024-05-17 15:20
definition: Because an HTTP triggered function also returns an HTTP response, the function returns a MultiResponse object, which represents both the HTTP and queue output.
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

> [!attention]
> This you write yourself!

Example:
```c#
public class MultiResponse
{
    [QueueOutput("outqueue",Connection = "AzureWebJobsStorage")]
    public string[] Messages { get; set; }
    public IActionResult HttpResponse { get; set; }
}
```

