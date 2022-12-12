using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using Microsoft.AspNetCore.Http;
using static System.Net.WebRequestMethods;


namespace MenuLunary.Controllers
{
    public class QrCodeController : Controller
    {
        // GET: QrCode

        [AllowAnonymous]
        public IActionResult Qr()
        {
            return View();
        }

        [HttpPost]

        [AllowAnonymous]
        public IActionResult Qr (string qrcode)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //qrcode = Path.GetPathRoot(qrcode) + "/Restaurante/Menu";
                //ViewBag.Url = Path.GetPathRoot(qrcode) + "/Restaurante/Menu";
                qrcode = Path.GetPathRoot(qrcode) + "https://restaurantelunary.herokuapp.com/Restaurante/Menu";

                QRCodeGenerator QRCodeGenerator = new QRCodeGenerator();
                QRCodeData QRCodeData = QRCodeGenerator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.Q);
                QRCode QRCode = new QRCode(QRCodeData);

                using (Bitmap Bitmap = QRCode.GetGraphic(20))
                {
                    Bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }
    }
}