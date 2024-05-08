using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace AZ204.Samples.Functions
{
    public class SimpleHttpTrigger
    {
        private readonly ILogger<SimpleHttpTrigger> _logger;

        public SimpleHttpTrigger(ILogger<SimpleHttpTrigger> logger)
        {
            _logger = logger;
        }

        [Function("SimpleHttpTrigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a requestfor a new QRCode.");
            string? text = req.Query.ContainsKey("text") ? req.Query["text"] : string.Empty; // Use null-conditional operator to safely access the value and provide a default value if it is null
            //log text
            _logger.LogInformation($"Text: {text}");

            byte[] qrCode = text != null ? GenerateQRCode(text) : new byte[0]; // Add null check for 'text' parameter
            return new FileContentResult(qrCode, "image/png");
        }
        public static byte[] GenerateQRCode(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCoder.PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);// Adjust the size as needed
        }        
    }
}
