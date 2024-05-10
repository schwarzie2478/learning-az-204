---
status: seedling
dg-publish: true
tags:
  - study/AZ-204
creation_date: 2024-05-07 20:59
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

A **function** contains two important pieces 
- your code, which can be written in various languages
- some config, the _[[function.json]]_ file.

## Function app

A [[Azure Function App]] provides an [[execution context]] in Azure in which your functions run.

In [[ASP.NET Core]] we can work with the models from its framework like IActionResult, HttpResponse HttpRequest

> [!warning]
> in .NET Framework we can only work with the built-in Built-in HTTP model with the class provided van the Functions SDK itself  [HttpRequestData](https://learn.microsoft.com/en-us/dotnet/api/microsoft.azure.functions.worker.http.httprequestdata?view=azure-dotnet&preserve-view=true) 

## Minimal example
program.cs
```c#
using Microsoft.Extensions.Hosting; 
using Microsoft.Azure.Functions.Worker; 
var host = new HostBuilder() 
	.ConfigureFunctionsWebApplication() 
	.Build(); 
host.Run();
```
function.cs
```c#
[Function("HttpFunction")]
public IActionResult Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
{
    return new OkObjectResult($"Welcome to Azure Functions, {req.Query["name"]}!");
}
```

### Minimum Requirements of a function:
- Function attribute with name
- HttpRequest req  with HttpTrigger attribute  
	- authorization requirement of function added
		- anonymous
	- http action
- returns OKObjectResult with contents as IActionResult
- access to query parameters through req.Query



Working in the [[isolated worker model]]
