---
status: planted
dg-publish: true
tags:
  - study/Microsoft/Graph
creation_date: 2024-05-27 16:21
definition: Microsoft Graph is the gateway to data and intelligence in Microsoft 365.
ms-learn-url: https://learn.microsoft.com/en-us/graph/overview
url: https://graph.microsoft.com
aliases:
---

|          |                                              |
| -------- | -------------------------------------------- |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

> [!NOTE] Definition
> `VIEW[{definition}][text(renderMarkdown)]`


![image](https://filedn.eu/lLCDT28fW4ahdtipln72iIF/public-vault-media/images/MicrosoftGraphAPI-overview.webp)

- Use Plurals for entities or singular for singletons. 
	- /groups   
	- /me
- Use Batching to combine multiple requests
- Use Rate limiting for protecting our systems

Best Practises by Microsoft Graph API:
https://learn.microsoft.com/en-us/graph/best-practices-concept

Rest Guidelines from Azure
https://github.com/microsoft/api-guidelines/blob/vNext/azure/Guidelines.md

General Architectual Principles
https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles


Insights into the succes of graph api: https://medium.com/product-dev-stories/insights-into-the-success-of-the-microsoft-graph-api-with-principal-api-architect-gareth-jones-29d05bc6a9bc

_Documentation First_ approach, the development process starts with the scenario documentation, since the high-level, customer-focused use case scenarios are what make for a great API.


This exact flexibility to use different methodologies is also the core principle of [SwaggerHub](https://swaggerhub.com/), the integrated development platform for all things Swagger. SwaggerHub allows [organizations and teams](https://swaggerhub.com/api-collaboration/) to follow whatever workflow that best fits their skillsets, to tap into every aspect of the API lifecycle, be it [design](https://swaggerhub.com/api-design-tool/), [documentation](https://swaggerhub.com/api-documentation/), or [deployment](https://swaggerhub.com/api-deployment/).


_Developer empathy is really important to us. The motto we follow in Microsoft is to build a great product for our developers, and do whatever it takes to win and sustain this developer trust.”_

Gareth believes that effective communication is key to maintaining a good, trustworthy relationship with your end customers.

_“If you’ve got the right telemetry in place, then you know which of your customers are still using your old APIs._

## Pagination

## Pluralization of collections, not singletons

## Batching

#### Bypassing URL length limitations with batching
#### DependsUpOn

requests depending on other requests, if one failed, the other requests return 424: Failed Dependency


## Rate limiting

## Handle Expected Errors

Document not found
Access not allowed
Throttleing
Server Unavailible
### Handling future members in evolvable enumerations

Evolvable enums is a mechanism that Microsoft Graph API uses to add new members to existing enumerations without causing a breaking change for applications.

Evolvable enums have a common _sentinel_ member called `unknownFutureValue` that demarcates known members that have been defined in the enum initially, and unknown members that are added subsequently or will be defined in the future.

If you design your application to handle unknown members as well, you can opt-in to receive those members by using an HTTP `Prefer` request header:

```http
Prefer: include-unknown-enum-members
```

## Handling storing data locally
Our application should also implement proper retention ==and deletion== policies.

## Optimizations

In general, for performance and even security or privacy reasons, ==you should only get the data your application really needs, and nothing more.==

### Use projections
Use the `$select` query paramete

### Getting minimal responses
Request minimal representation responses using the **Prefer** header set to `return=minimal`

### Track changes: delta query and webhook notifications

### Batching

## Reliability and support

Generate a unique GUID and send it on each Microsoft Graph REST request.
Also add it to your logging across all your services

