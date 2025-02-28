---
status: seedling
dg-publish: true
tags:
  - code/dotnet/dvz
creation_date: 2025-02-20 11:09
definition: "Task 19401: Backend - Temporary solution in INT1 to manually validate requests with a document that is hanging on virus scan"
url: https://dev.azure.com/ibzfgovbe/SinglePermit/_sprints/taskboard/Single%20Permit%20Intermediary%203/SinglePermit/Sprint%204?workitem=19401
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`


UpdateAttachmentHandler exists


## TODO

- Add web method
- Add request handler
- Test change attachement status

return updated attachment/permitrequest/nothing

Who fills the entity AttachementStatus?  AutoMapper
Double use as collection of Attachments and TranslatorString  :(

Audittrail implementation -> sandra to further refine



Fixes naming confusion 
- GetAttachment (s) -> OK
- demandrepo -> permitrequestrepo?
- AttachmentId vs storageKey?

Split bootstrap definitions in application layer?



