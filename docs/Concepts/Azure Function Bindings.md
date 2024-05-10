---
status: seedling
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 15:23
definition: The bindings property is where you configure both triggers and bindings.
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

Every binding requires the following settings

| Property    | Types  | Comments                                                                                                                             |
| ----------- | ------ | ------------------------------------------------------------------------------------------------------------------------------------ |
| `type`      | string | Name of binding. For example, [[queueTrigger]].                                                                                      |
| `direction` | string | Indicates whether the binding is for receiving data into the function or sending data from the function. For example, `in` or `out`. |
| `name`      | string | The name that is used for the bound data in the function. For example, `myQueue`.                                                    |

## Supported bindings

| Type                                                                                                                  | 1.x1 | 2.x and higher2 | Trigger | Input | Output |
| --------------------------------------------------------------------------------------------------------------------- | ---- | --------------- | ------- | ----- | ------ |
| [Blob storage](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-storage-blob)               | ✔    | ✔               | ✔       | ✔     | ✔      |
| [Azure Cosmos DB](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-cosmosdb-v2)             | ✔    | ✔               | ✔       | ✔     | ✔      |
| [Azure Data Explorer](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-data-explorer) |      | ✔               |         | ✔     | ✔      |
| [Azure SQL](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-azure-sql)                     |      | ✔               | ✔       | ✔     | ✔      |
| [Dapr](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-dapr)4                              |      | ✔               | ✔       | ✔     | ✔      |
| [Event Grid](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-grid)                   | ✔    | ✔               | ✔       |       | ✔      |
| [Event Hubs](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-hubs)                   | ✔    | ✔               | ✔       |       | ✔      |
| [HTTP & webhooks](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-http-webhook)            | ✔    | ✔               | ✔       |       | ✔      |
| [IoT Hub](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-event-iot)                       | ✔    | ✔               | ✔       |       |        |
| [Kafka](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-kafka)3                            |      | ✔               | ✔       |       | ✔      |
| [Mobile Apps](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-mobile-apps)                 | ✔    |                 |         | ✔     | ✔      |
| [Notification Hubs](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-notification-hubs)     | ✔    |                 |         |       | ✔      |
| [Queue storage](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-storage-queue)             | ✔    | ✔               | ✔       |       | ✔      |
| [Redis](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-cache)                             |      | ✔               | ✔       |       |        |
| [RabbitMQ](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-rabbitmq)3                      |      | ✔               | ✔       |       | ✔      |
| [SendGrid](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-sendgrid)                       | ✔    | ✔               |         |       | ✔      |
| [Service Bus](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-service-bus)                 | ✔    | ✔               | ✔       |       | ✔      |
| [SignalR](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-signalr-service)                 |      | ✔               | ✔       | ✔     | ✔      |
| [Table storage](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-storage-table)             | ✔    | ✔               |         | ✔     | ✔      |
| [Timer](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-timer)                             | ✔    | ✔               | ✔       |       |        |
| [Twilio](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-twilio)                           | ✔    | ✔               |         |       | ✔      |