---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud
creation_date: 2024-05-06 10:17
definition: The Open Systems Interconnection (OSI) model is a reference model from the International Organization for Standardization (ISO) that "provides a common basis for the coordination of standards development for the purpose of systems interconnection.
ms-learn-url: undefined
url: undefined
aliases:
  - "OSI Model"
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

## Layer architecture

The recommendation X.200 describes seven layers, labelled 1 to 7. Layer 1 is the lowest layer in this model.

| Layer | Name         | Function                                                                                                                                         |
| ----- | ------------ | ------------------------------------------------------------------------------------------------------------------------------------------------ |
| 7     | application  | High-level protocols such as for resource sharing or remote file access, e.g. [[Hypertext Transfer Protocol\|HTTP]].                             |
| 6     | presentation | Translation of data between a networking service and an application; including character encoding, data compression and encryption/decryption    |
| 5     | session      | Managing communication sessions, i.e., continuous exchange of information in the form of multiple back-and-forth transmissions between two nodes |
| 4     | transport    | Reliable transmission of data segments between points on a network, including segmentation, acknowledgement and multiplexing                     |
| 3     | network      | Structuring and managing a multi-node network, including addressing, routing and traffic control                                                 |
| 2     | data link    | Transmission of data frames between two nodes connected by a physical layer                                                                      |
| 1     | physical     | Transmission and reception of raw bit streams over a physical medium                                                                             |
