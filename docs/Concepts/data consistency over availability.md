---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud
creation_date: 2024-05-08 10:22
definition: undefined
ms-learn-url: undefined
url: https://en.wikipedia.org/wiki/CAP_theorem#:~:text=In%20the%20presence%20of%20a,date%20due%20to%20network%20partitioning.
aliases:
  - CAP
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
In [database theory](https://en.wikipedia.org/wiki/Database_theory "Database theory"), the **[[CAP theorem]]**, also named [[CAP theorem|Brewer's theorem]] after computer scientist [Eric Brewer](https://en.wikipedia.org/wiki/Eric_Brewer_(scientist) "Eric Brewer (scientist)"), states that any [distributed data store](https://en.wikipedia.org/wiki/Distributed_data_store "Distributed data store") can provide only [two of the following three](https://en.wikipedia.org/wiki/Trilemma "Trilemma") guarantees:[[1]](https://en.wikipedia.org/wiki/CAP_theorem#cite_note-Gilbert_Lynch-1)[[2]](https://en.wikipedia.org/wiki/CAP_theorem#cite_note-2)[[3]](https://en.wikipedia.org/wiki/CAP_theorem#cite_note-3)

[Consistency](https://en.wikipedia.org/wiki/Consistency_model "Consistency model")

Every read receives the most recent write or an error.

[[Availability]]

Every request receives a (non-error) response, without the guarantee that it contains the most recent write.

[Partition tolerance](https://en.wikipedia.org/wiki/Network_partitioning "Network partitioning")

The system continues to operate despite an arbitrary number of messages being dropped (or delayed) by the network between nodes.