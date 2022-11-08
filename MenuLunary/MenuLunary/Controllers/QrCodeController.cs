﻿using MenuLunary.Models;
using QRCoder;
using System.Web.Mvc;
namespace MenuLunary.Controllers
{
    public class QrCodeController : Controller
    {
        // GET: QrCode

        private readonly Contexto bd;
        public QrCodeController(Contexto contexto)
        {
            bd = contexto;
        }
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

                using (Bitmap bitmap = qrCode.GetGraphic(20))
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }
    }
}