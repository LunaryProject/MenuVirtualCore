using Microsoft.AspNetCore.Authorization;
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

        [AllowAnonymous]
        public ActionResult Qr()
        {
            return View();
        }

        [HttpPost]

        [AllowAnonymous]
        public ActionResult Qr (string qrcode)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                qrcode = Path.GetPathRoot(qrcode) + "/Restaurante/Menu";
                ViewBag.Url = Path.GetPathRoot(qrcode) + "/Restaurante/Menu";

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