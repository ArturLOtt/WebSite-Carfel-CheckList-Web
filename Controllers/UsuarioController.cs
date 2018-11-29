using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers
{
    public class UsuarioController : Controller
    {
        private int contador = 0;

        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {

            UsuarioModel usuario = new UsuarioModel ();
            usuario.Id = contador + 1;
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.Cliente = true;
            

            using (StreamWriter sw = new StreamWriter ("usuarioDB.txt", true)) {
                sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.Cliente};");

            }
            ViewBag.Mensagem = "Usuário Cadastrado";
            return RedirectToAction ("Login"
                // "Index", "Tarefa"
                );
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel ();
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];

            using (StreamReader sr = new StreamReader ("usuarioDB.txt")) {
                while (!sr.EndOfStream) {
                    string[] linha = sr.ReadLine ().Split (";");

                    if (linha[1] == usuario.Email && linha[2] == usuario.Senha) {
                        HttpContext.Session.SetString ("emailUsuario", usuario.Email);
                        return RedirectToAction ("Cadastrar", "Tarefa");
                    }
                }
            }

            ViewBag.Mensagem = "Usuário Inválido";

            return View ();
        }

    }
}