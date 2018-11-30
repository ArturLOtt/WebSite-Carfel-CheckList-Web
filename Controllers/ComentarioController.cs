using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers
{
    public class ComentarioController : Controller
    {
        public static UsuarioModel UsuarioAutenticado { get; private set; }

        int contador = 0;

        [HttpGet]
        public IActionResult Cadastrar () {
            if (string.IsNullOrEmpty (HttpContext.Session.GetString ("emailUsuario"))) {
                return RedirectToAction ("Login", "Usuario");
            }
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            ComentarioModel comentario = new ComentarioModel ();
            comentario.Id = contador + 1;
            comentario.usuario = UsuarioAutenticado;
            comentario.Descricao = form["descricao"];
            comentario.DataCriacao = DateTime.Now;
            comentario.Aprovado = false;

            using (StreamWriter sw = new StreamWriter ("comentarioDB.txt", true)) {
                sw.WriteLine ($"{comentario.Id};{comentario.usuario};{comentario.Descricao};{comentario.DataCriacao};{comentario.Aprovado}");
            }

            ViewBag.Mensagem = "Comentario cadastrada";

            return View ();
        }
    }
}
