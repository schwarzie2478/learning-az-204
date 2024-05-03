---
dg-publish: true
tags:
  - concept/SRE/cloud/azure
aliases:
  - AAD
definition: Azure Identity Management service, previously known as Azure Active Directory
ms-learn-url: https://learn.microsoft.com/en-us/azure/role-based-access-control/built-in-roles
creation_date: 2024-05-02 22:00

---

## General

|Built-in role|Description|ID|
|---|---|---|
|[Contributor](https://learn.microsoft.com/en-us/azure/role-based-access-control/built-in-roles/general#contributor)|Grants full access to manage all resources, but does not allow you to assign roles in Azure RBAC, manage assignments in Azure Blueprints, or share image galleries.|b24988ac-6180-42a0-ab88-20f7382dd24c|
|[Owner](https://learn.microsoft.com/en-us/azure/role-based-access-control/built-in-roles/general#owner)|Grants full access to manage all resources, including the ability to assign roles in Azure RBAC.|8e3af657-a8ff-443c-a75c-2fe8c4bcb635|
|[Reader](https://learn.microsoft.com/en-us/azure/role-based-access-control/built-in-roles/general#reader)|View all resources, but does not allow you to make any changes.|acdd72a7-3385-48ef-bd42-f606fba81ae7|
|[Role Based Access Control Administrator](https://learn.microsoft.com/en-us/azure/role-based-access-control/built-in-roles/general#role-based-access-control-administrator)|Manage access to Azure resources by assigning roles using Azure RBAC. This role does not allow you to manage access using other ways, such as Azure Policy.|f58310d9-a9f6-439a-9e8d-f62e7b41a168|
|[User Access Administrator](https://learn.microsoft.com/en-us/azure/role-based-access-control/built-in-roles/general#user-access-administrator)|Lets you manage user access to Azure resources.|18d7d88d-d35e-4fb5-a5c3-7773c20a72d9|


![[Microsoft Entra Id Privileged Role#^1175cd| About Privilegde Roles]]


> [!info]
> In a Microsoft Entra ID directory where user setting **Users can register applications** has been set to **No**, you must be a member of one of the following Microsoft Entra ID built-in roles (which have the action: `microsoft.directory/applications/createAsOwner` or `microsoft.directory/applications/create`):
> 
> - [Application Developer](https://learn.microsoft.com/en-us/entra/identity/role-based-access-control/permissions-reference#application-developer)
> - [Application Administrator](https://learn.microsoft.com/en-us/entra/identity/role-based-access-control/permissions-reference#application-administrator)
> - [Cloud Application Administrator](https://learn.microsoft.com/en-us/entra/identity/role-based-access-control/permissions-reference#cloud-application-administrator)
> - [Global Administrator](https://learn.microsoft.com/en-us/entra/identity/role-based-access-control/permissions-reference#global-administrator)
> - [Hybrid Identity Administrator](https://learn.microsoft.com/en-us/entra/identity/role-based-access-control/permissions-reference#hybrid-identity-administrator)
