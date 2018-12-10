using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Repositorio;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers {
    public class UsuarioController : Controller {
        private int contador = 0;

        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                cliente: true
            );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            usuarioRepositorio.Cadastrar (usuario);

            TempData["Mensagem"] = "Usuario cadastrado com sucesso!";
            ViewBag.Mensagem = "Usuário Cadastrado";
            return RedirectToAction ("Login");
        }

        [HttpGet]
        public IActionResult Login () {
            // revisar codigo depois
            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                TempData["Mensagem"] = "Finalizando as atividades do usuario anterior. Preparando para a operação de Login de outro usuário";
                TempData["UsuarioLogado"] = HttpContext.Session.GetString ("emailUsuario");
                return RedirectToAction ("Cadastrar");

            } else {
                ViewBag.UsuarioLogado = null;
                ViewBag.UsuarioId = null;
            }

            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (email: form["email"], senha: form["senha"]);

            using (StreamReader sr = new StreamReader ("usuarioDB.txt")) {
                while (!sr.EndOfStream) {
                    string[] linha = sr.ReadLine ().Split (";");

                    if (linha[2] == usuario.Email && linha[3] == usuario.Senha) {
                        // session armazena o email do usuario
                        HttpContext.Session.SetString ("emailUsuario", usuario.Email);

                        return RedirectToAction ("Cadastrar", "Comentario");
                    }
                }
            }

            ViewBag.Mensagem = "Usuário Inválido";
            return View ();
        }

        [HttpGet]
        public IActionResult Deslogar () {
            HttpContext.Session.Clear ();
            return RedirectToAction ("Principal", "Main");
        }

        public IActionResult Administrador () {

            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();

            ViewData["Comentarios"] = comentarioRepositorio.ListarADM ();

            return View ();
        }

    }
}