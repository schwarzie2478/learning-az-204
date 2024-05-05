---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-05 07:56
definition: Swapping from the staging slot to the production slot.
ms-learn-url: undefined
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
## When you swap two slots.

### Apply the settings from the target slot  to all instances of the source slot

- Slot-specific app settings and connection strings, if applicable.
- Continuous deployment settings, if enabled.
- App Service authentication settings, if enabled.

### Wait for every instance in the source slot to complete its restart.

### Trigger local cache initialization if enabled

If local cache is enabled, trigger local cache initialization by making an HTTP request to the application root ("/") on each instance of the source slot. Wait until each instance returns any HTTP response. Local cache initialization causes another restart on each instance.
### Trigger Application Initiation if auto swap is enabled

If auto swap is enabled with custom warm-up, trigger Application Initiation by making an HTTP request to the application root ("/") on each instance of the source slot.
   - If `applicationInitialization` isn't specified, trigger an HTTP request to the application root of the source slot on each instance.        
   - If an instance returns any HTTP response, it's considered to be warmed up.

### Swap the two slots by switching the routing rules for the two slots.

If all instances on the source slot are warmed up successfully, swap the two slots by switching the routing rules for the two slots. After this step, the target slot (for example, the production slot) has the app that's previously warmed up in the source slot.



### Cloning an slot

When you clone configuration from another deployment slot, the cloned configuration is editable. Some configuration elements follow the content across a swap (not slot specific), whereas other configuration elements stay in the same slot after a swap (slot specific). The following table shows the settings that change when you swap slots.

| Settings that are swapped                                           | Settings that aren't swapped                                                                        |
| ------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| General settings, such as framework version, 32/64-bit, web sockets | Publishing endpoints                                                                                |
| App settings (can be configured to stick to a slot)                 | Custom domain names                                                                                 |
| Connection strings (can be configured to stick to a slot)           | Non-public certificates and [[Transport Layer Security\|TLS]]/[[Secure Socket Layer\|SSL]] settings |
| Handler mappings                                                    | Scale settings                                                                                      |
| Public certificates                                                 | WebJobs schedulers                                                                                  |
| [[Azure App Service WebJobs]] content                                           | IP restrictions                                                                                     |
| [[Azure App Service Hybrid Connections]] *                          | Always On                                                                                           |
| Azure Content Delivery Network *                                    | Diagnostic log settings                                                                             |
| Service endpoints *                                                 | [[Cross-origin resource sharing]] (CORS)                                                            |
| Path mappings                                                       | Virtual network integration                                                                         |
|                                                                     | [[Service Principle\|Mananged Identity]]                                                            |
|                                                                     | Settings that end with the suffix `_EXTENSION_VERSION`                                              |
Features marked with an asterisk (*) are planned to be unswapped.

> [!NOTE]
> To make settings swappable, add the app setting `WEBSITE_OVERRIDE_PRESERVE_DEFAULT_STICKY_SLOT_SETTINGS` in every slot of the app and set its value to `0` or `false`. These settings are either all swappable or not at all. You can't make just some settings swappable and not the others. Managed identities are never swapped and are not affected by this override app setting.