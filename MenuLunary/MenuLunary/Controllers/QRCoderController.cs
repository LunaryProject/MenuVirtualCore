using MenuLunary.Models;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;

namespace MenuLunary.Controllers
{
    public class QRCoderController : Controller
    {
        // GET: QrCode
        public ActionResult QR()
        {
            return View();
        }

        [HttpPost]
        public ActionResult QR(string qrcode)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                

                qrcode = Request.Url.Authority + "/Restaurante/Menu";

                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qRCodeGenerator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                using (var bitmap = qrCode.GetGraphic(20))
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }

    }

    internal class QRCode
    {
        public QRCode(QRCodeData qrCodeData)
        {
        }

        internal Bitmap GetGraphic(int v)
        {
            throw new NotImplementedException();
        }
    }
}