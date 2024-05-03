---
dg-publish: true
tags:
  - concept/SRE/cloud/azure
definition: Site Extensions are management endpoints allows extending your site management tools.
ms-learn-url: https://azure.microsoft.com/en-us/blog/azure-web-sites-extensions/
creation_date: 2024-05-02 22:00
modification_date: 2024-05-02 22:05
---

Each [[Azure App Service|Azure Website]] provides an extensible management end point that allows you to leverage a powerful set of tools deployed as site extensions.

Ref: [link](https://github.com/projectkudu/kudu/wiki/Azure-Site-Extensions)

There are two main types of Site Extensions:
* Pre-Installed: they live under Program Files (x86) and are available to all sites. Kudu and Monaco are examples of this.
* Private: installed by the user as part of the site files. Only apply to one site at a time.

Generally, site extensions can modify applicationhost.config in arbitrary ways by applying transforms to it. 