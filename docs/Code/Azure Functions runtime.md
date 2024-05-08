---
status: planted
dg-publish: true
tags:
  - code/dotNet/azure
creation_date: 2024-05-07 21:14
definition: undefined
ms-learn-url: https://learn.microsoft.com/en-us/azure/azure-functions/functions-versions?tabs=isolated-process%2Cv4&pivots=programming-language-csharp
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!warning]
> As of December 13, 2022, function apps running on versions 2.x and 3.x of the Azure Functions runtime have reached the end of extended support. For more information, see [Retired versions](https://learn.microsoft.com/en-us/azure/azure-functions/functions-versions?tabs=isolated-process%2Cv4&pivots=programming-language-csharp#retired-versions)


## Runtime support

Azure Functions currently supports two versions of the runtime host.

| Version | Support level                                                                             | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ------- | ----------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 4.x     | [[Generally available\|GA]]                                                               | **_Recommended runtime version for functions in all languages._** Check out [Supported language versions](https://learn.microsoft.com/en-us/azure/azure-functions/functions-versions?tabs=isolated-process%2Cv4&pivots=programming-language-csharp#languages).                                                                                                                                                                                                  |
| 1.x     | GA ([support ends September 14, 2026](https://aka.ms/azure-functions-retirements/hostv1)) | Supported only for C# apps that must use .NET Framework. This version is in maintenance mode, with enhancements provided only in later versions. **Support will end for version 1.x on September 14, 2026.** We highly recommend you [migrate your apps to version 4.x](https://learn.microsoft.com/en-us/azure/azure-functions/migrate-version-1-version-4?pivots=programming-language-csharp), which supports .NET Framework 4.8, .NET 6, .NET 7, and .NET 8. |

> [!attention]
> Support ends September 14, 2026 for version 1.0

## Language usage
### Before Functions 2.x

??
### Functions 2.x

> [!attention]
> All functions in a function app must be authored in the same language.

### Function 4.x

??