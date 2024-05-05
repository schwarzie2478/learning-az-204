---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-05 09:44
definition: Handler mappings let you add custom script processors to handle requests for specific file extensions.
ms-learn-url: undefined
url: undefined
aliases:
  - path mapping
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
For uncontainerized windows apps the mappings consist of
- **Extension**: The file extension you want to handle, such as *_.php_ or _handler.fcgi_.
- **Script processor**: The absolute path of the script processor. 
- **Arguments**: Optional command-line arguments for the script processor.

You can add custom storage for your containerized app as a share.
