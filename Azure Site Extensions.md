# Azure Site Extensions

Ref: [link](https://github.com/projectkudu/kudu/wiki/Azure-Site-Extensions)

There are two main types of Site Extensions:
* Pre-Installed: they live under Program Files (x86) and are available to all sites. Kudu and Monaco are examples of this.
* Private: installed by the user as part of the site files. Only apply to one site at a time.

Generally, site extensions can modify applicationhost.config in arbitrary ways by applying transforms to it. 