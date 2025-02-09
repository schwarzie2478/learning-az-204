---
status: planted
dg-publish: true
tags:
  - unsorted
creation_date: 2025-02-05 11:22
definition: undefined
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


codelijsten, masterdata database

figma login ok?

enterprise architect

File upload / different from download service? encryption over gateway
bulk download not with actual attachments,> provide urls of each document already waiting somewhere
upload not in blob form on requests

daily tasks overview



Business domain explanation  DVZ

Business Domain  -  BD
Business capability - BC
Business actions   - BA
Business Process - BP
Business Service  - BS


High level BP turtle:
- **What and Why (Input)**: What are the causes of the process and what should it achieve?
- **With What**: What resources or tools are required for the process?
- **Who**: Who is responsible, who is involved in the process, and who will be affected by it?
- **What Results**: How can I measure the effectiveness of the process and how can I establish whether or not the targets of the process have been achieved?
- **How**: What methods should be applied and what information needs to be available?
- **What (Output)**: What is the actual result of the process?


underlying BP modeled in BPMN Camunda


Single Permit 
-> BD Stay
-> BC013 Management Short Stay
-> BC014 Management Long Stay
-> BC015 Naturalisation Management
-> BC016 Settlement Management

Transversaal 
important --> Person 360°  (all info together in well-formated content)

Transversal guidelines BB demande descision ( link??)
Business glossary


Key Concepts for each person
- Identitties
- requests
- notes
- contacts
- documents
- descisions
- activities

Inkomend : request,  na validatie demand


Activities developer:

ref lz: gertjan vanthienen, gerry hendrickx
data team: olivier lammens? wim cruysberghs
devops board? ask them
-> https://dev.azure.com/ibzfgovbe/eMigration%20Hybrid%20Cloud/_dashboards/dashboard/fc95c9ba-fb5b-4754-b16b-ff0779e89bb8



Security group:  ibz-dvzsp-landingzone-devs ?  --> OK
landingzones group not used in azure devops?  --> OK


software guidelines -> developer platform [Backstage](https://developer.platform.ibz.be/docs/default/component/platform-docs)
architecture  ( SAD document /develop platform)
[azure devops](https://dev.azure.com/ibzfgovbe/SinglePermit/)

Added as project admin ( everybody is project admin?)
(instead of  contributor/build admin/release manager/tester)

create repo -> by lz group, or we
code access -> OK
manage build
build local -> ok
setup database
deploy database
dacpac ( [guide](https://developer.platform.ibz.be/docs/default/component/guides/guides/dacpac/))  -->OK
-> what about roll-back?

-> what is b in USE [stay.singlepermit.b]
-> Identity_insert allow ( --> OK)
-> Attachment Table : position of varchar columns (-->not relevant, only for high volume data retrieval could this matter: solved)
-> Attachment Table : choice varchar nvarchar: FA/TA/ developer
-> [Json] VARBINARY (MAX)  (how big) why not NVARchar(Max)?

backlog/assignment User story example:


build code
known vulnerability / dependabot /sneek  ( build agents?)  -> OK alternative used
change code/  style guidelines/ editorconfig --> OK editorconfig used

check in code
-> feature branch naming conventions ( US number in name, git auto branch naming)
-> tag manually, not gitversion
-> main / dev / feature

deploy code
[Move to Prod checklist](https://developer.platform.ibz.be/docs/default/component/guides/guides/move-to-production-checklist/)

https://gitops-scp.d.we.platform.ibz.be/sign_in?redirect=%2F --> gertjan login lol


access in azure to test infrastructure

[[Use Case 16692]]  for [[Single Permit Application]]



Problem:  ACC  PROD 
redeploy -> gertjan help

how does the deployment work from ACC to PROD








