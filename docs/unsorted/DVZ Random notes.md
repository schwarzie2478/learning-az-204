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


[[FIGMA]] is used by designers and analysts
Screenshots in Azure Devops  
--> mismatched documentatione

figma login ok? or force sign off on screenshots

enterprise architect /camunda/bpmn


codelijsten, masterdata database or take from excell


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

support devbox: sam de wolf 
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

-> what is b in USE [stay.singlepermit.b]  probably database
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


# Introduction
video: https://ibzfgovbe-my.sharepoint.com/personal/franky_gabriels_ibz_be/_layouts/15/stream.aspx?id=%2Fpersonal%2Ffranky%5Fgabriels%5Fibz%5Fbe%2FDocuments%2FRecordings%2FIntroduction%20Business%20contexte%20DVZ%2D20240419%5F141348%2DMeeting%20Recording%2Emp4&referrer=StreamWebApp%2EWeb&referrerScenario=AddressBarCopied%2Eview%2Ed753aa00%2D0796%2D4bfd%2D966d%2Dd21abdb95f88

# Handy links

Dienst Vreemdelingenzaken.url		link naar de publieke website van de Dienst Vreemdelingenzaken, zeer nuttig om eens door te wandelen, of informatie over de werking op te zoeken.

 

https://prometis.crm4.dynamics.com	link naar Prometis, om je uren te registreren

SAD Release 2 New.pptx
 
https://ibzfgovbe.sharepoint.com/:p:/r/sites/dvzoe-single.permit/_layouts/15/Doc2.aspx?action=edit&sourcedoc=%7B4fa98c0e-a249-45a2-9486-ca94dd3570c3%7D&wdOrigin=TEAMS-MAGLEV.teamsSdk_ns.rwc&wdExp=TEAMS-TREATMENT&wdhostclicktime=1738583699467&web=1

TA Single Permit.docx
 https://ibzfgovbe.sharepoint.com/:w:/r/sites/dvzoe-single.permit/_layouts/15/Doc2.aspx?action=edit&sourcedoc=%7B0c8913b3-2241-484e-9dab-0770ea7c4826%7D&wdOrigin=TEAMS-MAGLEV.teamsSdk_ns.rwc&wdExp=TEAMS-TREATMENT&wdhostclicktime=1738584056713&web=1


Assist installations:  Sam De Wolf
winget install -e --id MuhammedKalkan.OpenLens

via azure portal -> perform connect actions to make kubectl config on local machine for each cluster


winget install -e --id mcmilk.7zip-zstd


