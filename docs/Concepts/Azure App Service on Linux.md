---
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-03 17:49
---
### Limitations

App Service on Linux does have some limitations:

- App Service on Linux isn't supported on [[App Service Plan#^cb1520|Shared pricing tier]].
- The Azure portal shows only features that currently work for Linux apps.
- When deployed to built-in images, your code and content are allocated a storage volume for web content, backed by Azure Storage. **The disk latency of this volume is higher and more variable than the latency of the container filesystem**. Apps that require heavy read-only access to content files may benefit from the custom container option, which places files in the container filesystem instead of on the content volume.

