---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-04 00:22
definition: The deployment slot functionality in App Service is a powerful tool that enables you to preview, manage, test, and deploy your different development environments.
ms-learn-url: undefined
url: undefined
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
## Benefits

Deploying your application to a non-production slot has the following benefits:

- You can validate app changes in a staging deployment slot before swapping it with the production slot.
- Deploying an app to a slot first and swapping it into production makes sure that all instances of the slot are warmed up before being swapped into production. This eliminates downtime when you deploy your app. The traffic redirection is seamless, and no requests are dropped because of swap operations. You can automate this entire workflow by configuring [[Azure App Service Auto swap|auto swap]] when pre-swap validation isn't needed.
- After a swap, the slot with previously staged app now has the previous production app. If the changes swapped into the production slot aren't as you expect, you can perform the same swap immediately to get your "last known good site" back.

## Tiers

Each [[App Service Plan]] tier supports a different number of deployment slots.

| Standard | Premium (v1-v3) | Isolated |
| -------- | --------------- | -------- |
| 5        | 20              | 20       |

## Content of slot

When you create a new slot the new deployment slot has no content, even if you clone the settings from a different slot.
You can deploy to the slot from a different repository branch or a different repository.

### Manual Swapping

[[Azure App Service Swap with preview|Swap with preview]]


### [[Azure App Service Auto swap|Auto Swapping]]

### Custom Warm-up

Some apps might require custom warm-up actions before the swap. The `applicationInitialization` configuration element in web.config lets you specify custom initialization actions. The swap operation waits for this custom warm-up to finish before swapping with the target slot.

```xml
<system.webServer> <applicationInitialization> 
	<add initializationPage="/" hostName="[app hostname]" /> 
	<add initializationPage="/Home/About" hostName="[app hostname]" /> </applicationInitialization> </system.webServer>
```

