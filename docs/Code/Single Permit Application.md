---
status: seedling
dg-publish: true
tags:
  - code/dotnet/dvz
creation_date: 2025-02-07 12:20
definition: Handle requests for single permits
ms-learn-url: undefined
url: undefined
aliases:
  - dvzsp
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`

See alessio for more feedback, pierre henry,

## Remarks

Auditing uses  [[Audit.NET]]
> [!caution] 
don't forget to remove personal information from audit trail.

See automapper configuration.


AttachmentStatusId -> hardcoded ( replace with named enum?)
[[Use Case 16692]]


[[Use Case 19401]]

## databases

ibz-scp-we-d-sql-server-primary.database.windows.net,1433

	## Technical debt
	AttachmentId vs Is?

//"SinglePermitDb": "Server=(localdb)\\mssqllocaldb;Database=SinglePermit;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false"

logging
traces | where cloud_RoleName contains "stay-singlepermit-request-manager-api"

TA:

 https://ibzfgovbe.sharepoint.com/:w:/r/sites/dvzoe-single.permit/_layouts/15/doc2.aspx?sourcedoc=%7B0C8913B3-2241-484E-9DAB-0770EA7C4826%7D&file=TA%20Single%20Permit.docx&action=default&mobileredirect=true&wdOrigin=TEAMS-MAGLEV.p2p_ns.rwc&wdExp=TEAMS-TREATMENT&wdhostclicktime=1740133512635&web=1
 