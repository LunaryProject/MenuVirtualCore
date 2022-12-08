using Microsoft.AspNetCore.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using PagedList;
using ActionResult = Microsoft.AspNetCore.Mvc.ActionResult;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using LunaryCore.Models;
using System.Drawing.Imaging;
using QRCoder;
using System.Drawing;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace MenuLunary.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly Contexto bd;
        public AdminController(Contexto contexto)
        {
            bd = contexto;
        }
        // GET: Admin

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult ListPratos(int? i)
        {
            var lista = bd.Restaurante.ToList().ToPagedList(i ?? 1, 15);
            return View(lista);

        }
        [AllowAnonymous]
        public ActionResult Create()
        {
            ViewBag.listacategoria = bd.Categorias.ToList();
            return View();

        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Create(int? id, string nome, float preco, string descricao, float precopromocao, string categoria, IFormFile imagem, string oferta, string disponibilidade)
        {

            
            Restaurante novoRestaurante = new Restaurante();
            novoRestaurante.RESTANOME = nome;
            novoRestaurante.RESTAPRECO = preco;
            novoRestaurante.RESTADESCRICAO = descricao;
            novoRestaurante.RESTAPREPROMOCAO = precopromocao;
            novoRestaurante.RESTACATEGORIA = categoria;
            if (imagem != null)
            {
                using (var ms = new MemoryStream())
                {
                    imagem.CopyToAsync(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    novoRestaurante.imagem = fileBytes.ToArray();
                }
            }

            if (oferta == "true")
            {
                novoRestaurante.Oferta = true;
            }
            else
            {
                novoRestaurante.Oferta = false;
            }


            if (disponibilidade == "true")
            {
                novoRestaurante.Disponibilidade = true;
            }
            else
            {
                novoRestaurante.Disponibilidade = false;
            }


            //novoRestaurante.Oferta = oferta;
            bd.Restaurante.Add(novoRestaurante);
            bd.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]

        [AllowAnonymous]
        public ActionResult Editar(int? id)
        {
            if (id != null)
            {
                try
                {
                    Restaurante Localizarrestaurante = bd.Restaurante.ToList().Where(x => x.RESTAUID == id).First();
                    ViewBag.listacategoria = bd.Categorias.ToList();
                    return View(Localizarrestaurante);
                }
                catch (Exception)
                {
                    return RedirectToAction("ListPratos");
                }

            }
            return RedirectToAction("ListPratos");

        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Editar(int? id, string nome, float preco, string descricao, float precopromocao, string categoria, IFormFile imagem, string oferta, string disponibilidade)
        {
            Restaurante atualizarrestaurante = bd.Restaurante.ToList().Where(x => x.RESTAUID == id).First();
            atualizarrestaurante.RESTANOME = nome;
            atualizarrestaurante.RESTAPRECO = preco;
            atualizarrestaurante.RESTADESCRICAO = descricao;
            atualizarrestaurante.RESTAPREPROMOCAO = precopromocao;
            atualizarrestaurante.RESTACATEGORIA = categoria;

            if (imagem != null)
            {
                using (var ms = new MemoryStream())
                {
                    imagem.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    atualizarrestaurante.imagem = fileBytes.ToArray();
                }
            }

            if (oferta == "true")
            {
                atualizarrestaurante.Oferta = true;
            }
            else
            {
                atualizarrestaurante.Oferta = false;
            }


            if (disponibilidade == "true")
            {
                atualizarrestaurante.Disponibilidade = true;
            }
            else
            {
                atualizarrestaurante.Disponibilidade = false;
            }


            bd.Entry(atualizarrestaurante).State = EntityState.Modified;
            bd.SaveChanges();
            return RedirectToAction("ListPratos");
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Excluir(int? id)
        {
            if (id != null)
            {
                try
                {
                    Restaurante excluiroproduto = bd.Restaurante.ToList().Where(x => x.RESTAUID == id).First();
                    return View(excluiroproduto);
                }
                catch (Exception)
                {
                    return View("ListPratos");
                }
            }
            return View("ListPratos");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult ExcluirConfirmar(int? id)
        {
            if (id != null)
            {
                Restaurante excluiroproduto = bd.Restaurante.ToList().Where(x => x.RESTAUID == id).First();
                bd.Restaurante.Remove(excluiroproduto);

                try
                {
                    bd.SaveChanges();
                }
                catch (Exception)
                {
                    return RedirectToAction("ListPratos");
                }
            }

            return RedirectToAction("ListPratos");
        }

        [AllowAnonymous]

        public ActionResult ProdutosCurtidos()
        {
            ViewBag.Rank = bd.Restaurante.ToList().OrderByDescending(x => ((uint?)x.Curtidas)).ToList();
            return View();
        }

        [AllowAnonymous]
        public ActionResult Qr()
        {
            return View();
        }

        [HttpPost]

        [AllowAnonymous]
        public ActionResult Qr(string qrcode)
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
