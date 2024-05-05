---
status: planted
dg-publish: true
aliases:
  - PBS
definition: We can predict the expected consistency of an eventually consistent data store using models we've developed, called Probabilistically Bounded Staleness.
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-02 18:40
url: http://pbs.cs.berkeley.edu/
---
| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |




Data stores aren't black boxes. We know how they're built, and, accordingly, should be able to predict how they operate in practice. While eventually consistent data stores make no _guarantees_ about the recency of data they return, we can model their operation to predict what consistency they provide. We call this Probabilistically Bounded Staleness, or PBS.