---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-05 09:24
definition: In App Service, app settings are variables passed as environment variables to the application code.
ms-learn-url: https://learn.microsoft.com/en-us/training/modules/configure-web-app-settings/2-configure-application-settings
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |


> [!note] 
> For Linux apps and custom containers, App Service passes app settings to the container using the `--env` flag to set the environment variable in the container.


> [!attention] 
> The values in App Service override the ones in _Web.config_ or _appsettings.json_.


> [!note]
> App settings are always encrypted when stored ([[encrypted-at-rest]]).


> [!Note] 
> In a default, or custom, Linux container any nested JSON key structure in the app setting name any `:` should be replaced by `__` (double underscore).

