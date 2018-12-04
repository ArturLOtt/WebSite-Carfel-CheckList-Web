using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers {
    public class UsuarioController : Controller {
        private int contador = 0;

        [HttpGet]
        public ActionResult Cadastrar () {

            // string id = HttpContext.Session.GetString ("IdUsuario");

            // if (id != null) {
            //     int idInt = int.Parse (id);
            //     UsuarioModel usuario = BuscarPorId (idInt);
            //     // ViewBag.UsuarioId = usuario.Id;
            //     ViewBag.UsuarioLogado = usuario.Nome;
            //     ViewBag.AdminBool = usuario.Administrador;
            // } else {
            //     ViewBag.UsuarioLogado = null;
            //     ViewBag.UsuarioId = null;
            // }

            return View ();
        }

        // private UsuarioModel BuscarPorId(int idInt)
        // {
        //     foreach(UsuarioModel usuario in UsuariosSalvos)
        //     {
        //         if (id == usuario.Id)
        //         {
        //             return usuario;
        //         }
        //         return usuario;
        // }

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

            TempData["Mensagem"] = "Usuario cadastrado com sucesso!";
            ViewBag.Mensagem = "Usuário Cadastrado";
            return RedirectToAction ("Login");
        }

        [HttpGet]
        public IActionResult Login () {

            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                TempData["Mensagem"] = "Finalizando as atividades do usuario anterior. Preparando para a operação de Login de outro usuário";

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


        //     [HttpPost]
        //     public IActionResult LoginAdmin(IFormCollection form){
        //         UsuarioModel usuario = new UsuarioModel( email: form["email"], senha: form["senha"]);

        //         UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        //         UsuarioModel usuarioModel = usuarioRepositorio.EmailSenha(usuario.Email, usuario.Senha);           

        //         if(usuarioModel != null){
        //             if(usuarioModel.Email.Contains("admin@carfel.com")){
        //             HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
        //             HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
        //             HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());

        //             usuarioModel.Administrador = true;
        //             return RedirectToAction ("IndexADM", "HomeADM");
        //         }
        //             HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
        //             HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
        //             HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());

        //             ViewBag.LoginSucesso = "Login Efetuado";

        //             return RedirectToAction ("Index", "Home");
        //         }else{
        //             ViewBag.LoginFalha = "Acesso inválido";
        //         }

        //         return View();
        //     }

        [HttpGet]
        public IActionResult Deslogar () {
            HttpContext.Session.Clear ();
            return RedirectToAction ("Principal");
        }
        
    }
}