---
status: seedling
dg-publish: true
tags:
  - unsorted
creation_date: 2024-05-08 23:11
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

.NET Library to generate [[QRCode]]

## How to use this library

```csharp
using QRCoder;

public static byte[] GenerateQRCode(string text)
{
    QRCodeGenerator qrGenerator = new QRCodeGenerator();
    QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
    QRCode qrCode = new QRCode(qrCodeData);
    Bitmap qrCodeImage = qrCode.GetGraphic(20); // Adjust the size as needed

    using (MemoryStream stream = new MemoryStream())
    {
        qrCodeImage.Save(stream, ImageFormat.Png);
        return stream.ToArray();
    }
}
```
