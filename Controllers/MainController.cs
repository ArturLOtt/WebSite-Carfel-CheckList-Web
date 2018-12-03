using Microsoft.AspNetCore.Mvc;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers {
    public class MainController : Controller {
        
        [HttpGet]
        public IActionResult About () {
            // ViewBag.UsuarioNome = HttpContext.Session.GetString ("UsuarioNome");
            // ViewBag.Tipo = HttpContext.Session.GetString ("Tipo");
            return View ();
        }

        public IActionResult Faq () {

            return View ();
        }

        public IActionResult Formulario () {

            return View ();
        }

        public IActionResult Principal () {

            return View ();
        }

    }
}