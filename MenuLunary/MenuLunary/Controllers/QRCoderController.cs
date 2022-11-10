using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;


namespace MenuLunary.Controllers
{
    public class QRCoderController : Controller
    {
        // GET: QrCode
        public IActionResult QR()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QR (string qrcode)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                

                QRCodeGenerator QRCodeGenerator = new QRCodeGenerator();
                QRCodeData QRCodeData = QRCodeGenerator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.Q);
                QRCode QRCode = new QRCode(QRCodeData);

                using (Bitmap Bitmap = QRCode.GetGraphic(10))
                {
                    Bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }

    }

    
}