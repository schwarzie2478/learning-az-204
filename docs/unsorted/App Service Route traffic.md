---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-05 08:58
definition: undefined
ms-learn-url: undefined
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
By default, all client requests to the app's production URL (`http://<app_name>.azurewebsites.net`) are routed to the production slot.

## Route production traffic automatically
To route production traffic automatically:

1. Go to your app's resource page and select **Deployment slots**.
2. In the **Traffic %** column of the slot you want to route to, specify a percentage (between 0 and 100) to represent the amount of total traffic you want to route. Select **Save**.
## Route production traffic manually

To route production traffic manually, you use the `x-ms-routing-name` query parameter.

To let users opt out of your beta app, for example, you can put this link on your webpage:
```HTML
<a href="<webappname>.azurewebsites.net/?x-ms-routing-name=self">
	Go back to production app
</a>
```
## Routing Cookie

On the client browser, you can see which slot your session is pinned to by looking at the `x-ms-routing-name` cookie in your HTTP headers. A request that's routed to the "staging" slot has the cookie `x-ms-routing-name=staging`. 

> [!summary] 
> A request that's routed to the production slot has the cookie `x-ms-routing-name=self`.

