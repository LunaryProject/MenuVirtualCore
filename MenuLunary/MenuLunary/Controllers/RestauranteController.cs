using Microsoft.AspNetCore.Mvc;
using MenuLunary.Models;

namespace MenuLunary.Controllers
{
    public class RestauranteController : Controller
    {
        // GET: Restaurante

        private readonly Contexto bd;
        public RestauranteController(Contexto contexto)
        {
            bd = contexto;
        }
        

        [HttpGet]
        public ActionResult Menu()
        {
            ViewBag.ListCategorias = bd.Categorias.ToList();
            ViewBag.Rank = bd.Restaurante.ToList().OrderByDescending(x => ((uint)x.Curtidas)).ToList();
            ViewBag.Campanha = bd.Campanhas.ToList();
            return View(bd.Restaurante.ToList());
        }

        [HttpGet]
        public ActionResult Detalhes(int? id)
        {
            Restaurante restaurante = bd.Restaurante.Find(id);
            return PartialView(restaurante);
        }

        [HttpPost]
        public ActionResult ContagemLikes(int? id, bool status)
        {
            Restaurante atulizarLikes = bd.Restaurante.ToList().Where(x => x.RESTAUID == id).First();
            if (status)
            {
                atulizarLikes.Curtidas += 1;
            }
            else
            {
                if (atulizarLikes.Curtidas > 0)
                {
                    atulizarLikes.Curtidas -= 1;
                }
            }

            bd.Entry(atulizarLikes).State = EntityState.Modified;
            bd.SaveChanges();
            return RedirectToAction("menu");
        }
    }
}
