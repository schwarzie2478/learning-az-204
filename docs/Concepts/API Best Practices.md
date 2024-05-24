---
status: planted
dg-publish: true
tags:
  - concept/SRE
  - best-practices
creation_date: 2024-05-24 18:23
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


## Different ways to connect to an API

### Rest API

```mermaid
sequenceDiagram
  participant Client
  participant Server
  Client->>Server: GET /resource
  Server-->>Client: 200 OK, resource
```
### Web Socket
```mermaid
sequenceDiagram
  participant Client
  participant Server
  Client->>Server: Connect WebSocket
  Note over Client,Server: Connection Established
  Client->>Server: Send Message
  Server-->>Client: Acknowledge Receipt
  Server->>Client: Send Message
  Client-->>Server: Acknowledge Receipt
```

### Publish  Subscribe
```mermaid
sequenceDiagram
  participant Publisher
  participant Subscriber
  Publisher->>Subscriber: Publish message
  Note over Publisher,Subscriber: Message is stored in a topic
  Subscriber-->>Publisher: Acknowledge receipt
```

### Webhooks
```mermaid
sequenceDiagram
  participant Service
  participant Webhook
  Service->>Webhook: Event trigger
  Note over Service,Webhook: Event is stored
  Webhook-->>Service: Acknowledge receipt
```
### Callback Urls

```mermaid
sequenceDiagram
  participant Client
  participant Server
  Client->>Server: Request with callback URL
  Note over Client,Server: Server processes request
  Server-->>Client: Response to callback URL
```
