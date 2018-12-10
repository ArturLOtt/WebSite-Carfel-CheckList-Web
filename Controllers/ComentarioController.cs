using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Repositorio;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers {
    public class ComentarioController : Controller {
        public static UsuarioModel UsuarioAutenticado { get; private set; }

        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();

        int contador = 0;

        [HttpGet]
        public IActionResult Cadastrar () {
            if (string.IsNullOrEmpty (HttpContext.Session.GetString ("emailUsuario"))) {
                return RedirectToAction ("Login", "Usuario");
            }

            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();

            ViewData["Comentarios"] = comentarioRepositorio.Listar ();

            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {

            ComentarioModel comentario = new ComentarioModel ();
            // comentario.Usuario = UsuarioAutenticado;
            comentario.Descricao = form["descricao"];
            comentario.DataCriacao = DateTime.Now;
            comentario.Aprovado = false;
            comentario.NomeUsuario = HttpContext.Session.GetString ("emailUsuario");

            ComentarioRepositorio comRepo = new ComentarioRepositorio ();
            comRepo.Criar (comentario);

            TempData["Mensagem"] = "Comentário cadastrado com sucesso!";
            ViewBag.Mensagem = "Comentário Cadastrado";

            // using (StreamWriter sw = new StreamWriter ("comentarioDB.txt", true)) {
            //     sw.WriteLine ($"{comentario.Id};{HttpContext.Session.GetString("emailUsuario")};{comentario.Descricao};{comentario.DataCriacao};{comentario.Aprovado}");
            // }

            return RedirectToAction ("Cadastrar");
        }

        [HttpGet]
        public IActionResult Listar () {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();

            ViewData["Comentarios"] = comentarioRepositorio.Listar ();
            return View ();
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            ComentarioRepositorio.Excluir (id);

            TempData["Mensagem"] = "Comentario excluído";

            return RedirectToAction ("Administrador", "Usuario");
        }

        [HttpGet]
        public IActionResult Aprovar (int id) {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ComentarioRepositorio.Aprovar (id);

            TempData["Mensagem"] = "Comentario Aprovado";
            ViewData["comentarios"] = comentarioRepositorio.Listar();

            return  RedirectToAction ("Administrador", "Usuario");

        }



        public IActionResult ListarParaADM () {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();

            ViewData["Comentarios"] = comentarioRepositorio.ListarADM ();
            return View ();
        }






    }
}