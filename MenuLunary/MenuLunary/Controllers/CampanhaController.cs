using MenuLunary.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuLunary.Controllers
{
    public class CampanhaController : Controller
    {
        public ActionResult Index()
        {
            return View(bd.Campanhas.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Descricao, float CAMPRECO, HttpPostedFileBase Foto)
        {
            Campanhas novacampanha = new Campanhas();
            novacampanha.CAMDESCRICAO = Descricao;
            novacampanha.CAMPRECO = CAMPRECO;
            if (Foto != null)
            {
                try
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        Foto.InputStream.CopyTo(memoryStream);
                        novacampanha.CAMFOTO = memoryStream.ToArray();
                    }
                }
                catch (Exception)
                {
                    return RedirectToAction("caixinha.js");
                }

            }

            bd.Campanhas.Add(novacampanha);
            bd.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Editar(int? id)
        {
            Campanhas Localizarcampanha = bd.Campanhas.ToList().Where(x => x.CAMID == id).First();
            return View(Localizarcampanha);
        }

        [HttpPost]
        public ActionResult Editar(int? id, string Descricao, float preco, HttpPostedFileBase Foto)
        {
            Campanhas atualizarcampanhas = bd.Campanhas.ToList().Where(x => x.CAMID == id).First();
            atualizarcampanhas.CAMDESCRICAO = Descricao;
            atualizarcampanhas.CAMPRECO = preco;
            if (Foto != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    Foto.InputStream.CopyTo(memoryStream);
                    atualizarcampanhas.CAMFOTO = memoryStream.ToArray();
                }
            }
            bd.Entry(atualizarcampanhas).State = EntityState.Modified;
            bd.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult Excluir(int? id)
        {

            if (id != null)
            {
                try
                {
                    Campanhas excluir = bd.Campanhas.ToList().Where(x => x.CAMID == id).First();
                    return View(excluir);
                }
                catch (Exception)
                {
                    return View("ListPratos");
                }
            }
            return View("ListPratos");
        }
        [HttpPost]
        public ActionResult ExcluirConfirma(int? id)
        {
            if (id != null)
            {
                try
                {
                    Campanhas excluircampanha = bd.Campanhas.ToList().Where(x => x.CAMID == id).First();
                    bd.Campanhas.Remove(excluircampanha);
                    bd.SaveChanges();
                }
                catch (Exception)
                {
                    return RedirectToAction("index");
                }
            }
            return RedirectToAction("index");
        }
    }
}
