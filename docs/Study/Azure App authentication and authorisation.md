---
status: planted
dg-publish: true
tags:
  - study/AZ-204
creation_date: 2024-05-04 17:42
definition: Azure App Service provides built-in authentication and authorization support, so you can sign in users and access data by writing minimal, or no code in your web app, RESTful API, mobile back end, and Azure Functions.
ms-learn-url: https://learn.microsoft.com/en-us/training/modules/introduction-to-azure-app-service/5-authentication-authorization-app-service
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

## Built-in authentication

The built-in authentication feature for App Service and Azure Functions can save you time and effort by providing out-of-the-box authentication with [[Federated Identity Providers]], allowing you to focus on the rest of your application.
- Azure App Service allows you to integrate various auth capabilities into your web app or API without implementing them yourself.
- It’s built directly into the platform and doesn’t require any particular language, SDK, security expertise, or code.
- You can integrate with multiple login providers. For example, Microsoft Entra ID, Facebook, Google, Twitter.

## Identity providers

App Service uses [[Federated Identity]], in which a third-party identity provider manages the user identities and authentication flow for you.