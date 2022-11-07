using MenuLunary.Models;
using Microsoft.AspNetCore.Mvc;
using Projeto_Lunary.Models;
using System.Web.Mvc;
using System.Web.Security;
using ActionResult = System.Web.Mvc.ActionResult;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace MenuLunary.Controllers
{
    public class ContaController : Controller
    {
        private readonly Contexto bd;
        public ContaController(Contexto contexto)
        {
            bd = contexto;
        }

        [AllowAnonymous]

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var achou = (login.Usuario == "admin" && login.Senha == "123");

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }

            }
            else
            {
                ModelState.AddModelError("", "Login inválido.");
            }

            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Admin");
        }

    }
}
