---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 12:20
definition: Azure Logic Apps is a serverless workflow integration platform.
ms-learn-url: https://learn.microsoft.com/en-us/azure/logic-apps/logic-apps-overview
url: undefined
aliases: []
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

An orchestration is a collection of functions or steps, called ==actions== in Logic Apps, that are executed to accomplish a complex task.

For Logic Apps, you create orchestrations by using a GUI or editing configuration files.

 [[Power Automate]] in [[Office 365]] is built on the Azure Logic Apps platform.

## Differences between Power Automate and Logic Apps

|                                        | Power Automate                                                                                                                                                                                                                                                                               | Logic Apps                                                                                                                                                                                                                                                                             |
| -------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Users                                  | Office workers, business users, SharePoint administrators                                                                                                                                                                                                                                    | Pro integrators and developers, IT pros                                                                                                                                                                                                                                                |
| Scenarios                              | Self-service                                                                                                                                                                                                                                                                                 | Advanced integrations                                                                                                                                                                                                                                                                  |
| Design tool                            | In-browser and mobile app, UI only                                                                                                                                                                                                                                                           | In-browser, [Visual Studio Code](https://learn.microsoft.com/en-us/azure/logic-apps/quickstart-create-logic-apps-visual-studio-code), and [Visual Studio](https://learn.microsoft.com/en-us/azure/logic-apps/quickstart-create-logic-apps-with-visual-studio) with code view available |
| Application lifecycle management (ALM) | Power Platform [provides tools](https://learn.microsoft.com/en-us/power-platform/alm/tools-apps-used-alm) that integrate with DevOps and [GitHub Actions](https://learn.microsoft.com/en-us/power-platform/alm/devops-github-actions) to let you build automated pipelines in the ALM cycle. | Azure DevOps: source control, testing, support, automation, and manageability in [Azure Resource Manager](https://learn.microsoft.com/en-us/azure/logic-apps/logic-apps-azure-resource-manager-templates-overview)                                                                     |
| Admin experience                       | Manage Power Automate environments and [[Data Loss Prevention]] (DLP) policies, track licensing: [Admin center](https://admin.powerplatform.microsoft.com/)                                                                                                                                  | Manage resource groups, connections, access management, and logging: [Azure portal](https://portal.azure.com/)                                                                                                                                                                         |
| Security                               | Microsoft 365 security audit logs, DLP, [encryption at rest](https://wikipedia.org/wiki/Data_at_rest#Encryption) for sensitive data                                                                                                                                                          | Security assurance of Azure: [Azure security](https://www.microsoft.com/en-us/trustcenter/Security/AzureSecurity), [Microsoft Defender for Cloud](https://azure.microsoft.com/services/security-center/), [audit logs](https://azure.microsoft.com/blog/azure-audit-logs-ux-refresh/)  |

Not the same as [[Power Apps]]

## Examples

[[Working with excel dates in Logic Apps]]
