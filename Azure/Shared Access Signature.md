---
tags:
  - azure
aliases:
  - sas
definition: A shared access signature (SAS) provides secure delegated access to resources in your storage account. With a SAS, you have granular control over how a client can access your data.
---
[Ms Learn](https://learn.microsoft.com/en-us/azure/storage/common/storage-sas-overview)

A shared access signature is a token that is appended to the URI for an Azure Storage resource. The token that contains a special set of query parameters that indicate how the resources may be accessed by the client.

A shared access signature can take one of the following two forms:

- **Ad hoc SAS**. When you create an ad hoc SAS, the start time, expiry time, and permissions are specified in the SAS URI. Any type of SAS can be an ad hoc SAS.
    
- **Service SAS with stored access policy**. A stored access policy is defined on a resource container, which can be a blob container, table, queue, or file share. The stored access policy can be used to manage constraints for one or more service shared access signatures. When you associate a service SAS with a stored access policy, the SAS inherits the constraints—the start time, expiry time, and permissions—defined for the stored access policy.

When you disallow Shared Key authorization for a storage account, Azure Storage rejects all subsequent requests to that account that are authorized with the account access keys. Only secured requests that are authorized with Microsoft Entra ID will succeed. For more information about using Microsoft Entra ID, see [Authorize access to data in Azure Storage](https://learn.microsoft.com/en-us/azure/storage/common/authorize-data-access).

The **AllowSharedKeyAccess** property of a storage account is not set by default and does not return a value until you explicitly set it. The storage account permits requests that are authorized with Shared Key when the property value is **null** or when it is **true**.