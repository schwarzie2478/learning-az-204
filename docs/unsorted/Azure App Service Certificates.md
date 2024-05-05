---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-05 10:00
definition: undefined
ms-learn-url: undefined
url: undefined
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
Uses [[certificates]]

## Adding Certificates to App:

| Option                                        | Description                                                                                                                                                      |
| --------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Create a free App Service managed certificate | A private certificate that's free of charge and easy to use if you just need to secure your custom domain in App Service.                                        |
| Purchase an App Service certificate           | A private certificate that's managed by Azure. It combines the simplicity of automated certificate management and the flexibility of renewal and export options. |
| Import a certificate from [[Azure Key Vault]] | Useful if you use Azure Key Vault to manage your certificates.                                                                                                   |
| Upload a [[private certificate]]              | If you already have a private certificate from a third-party provider, you can upload it.                                                                        |
| Upload a [[public certificate]]               | Public certificates aren't used to secure custom domains, but you can load them into your code if you need them to access remote resources.                      |

## Private certificate requirements

The free **App Service managed certificate** and the **App Service certificate** already satisfy the requirements of App Service. If you want to use a private certificate in App Service, your certificate must meet the following requirements:

- Exported as a password-protected PFX file, encrypted using triple DES.
- Contains private key at least 2048 bits long
- Contains all intermediate certificates in the certificate chain

To secure a custom domain in a TLS binding, the certificate has other requirements:

- Contains an [[Extended Key Usage]] for server authentication ([[Object Identifiers|OID]] = 1.3.6.1.5.5.7.3.1)
- Signed by a [[trusted certificate authority]]

## Create free managed certificate

To create custom TLS/SSL bindings or enable client certificates for your App Service app, your App Service plan must be in the **Basic**, **Standard**, **Premium**, or **Isolated** tier.

### Limitations

The free certificate comes with the following limitations:

- Doesn't support wildcard certificates.
- Doesn't support usage as a client certificate by using certificate thumbprint, which is planned for deprecation and removal.
- Doesn't support private DNS.
- Isn't exportable.
- Isn't supported in an App Service Environment (ASE).
- Only supports alphanumeric characters, dashes (-), and periods (.).

## Import an App Service Certificate

If you purchase an [[Azure App Service Certificates]] from Azure, Azure manages the following tasks:

- Takes care of the purchase process from certificate provider.
- Performs domain verification of the certificate.
- Maintains the certificate in Azure Key Vault.
- Manages certificate renewal.
- Synchronize the certificate automatically with the imported copies in App Service apps.

If you already have a working App Service certificate, you can:

- Import the certificate into App Service.
- Manage the certificate, such as renew, rekey, and export it.

 Note

> [!attention] 
> App Service Certificates are not supported in [[Azure National Clouds]] at this time.

