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
            UsuarioModel usuario = new UsuarioModel (
                nome:form["nome"],
                email: form["email"],
                senha: form["senha"],
                cliente: true
                );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuario);

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

                        // Save data to sessionStorage
                        // sessionStorage.setItem ('key', 'value');

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

/*


using System.Collections.Generic;
using Senai_Financas_Mvc_Web_master.Repositorios;

namespace Senai.Financas.Web.Mvc.Controllers {
    public class UsuarioController : Controller {

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.Login(form["email"], form["senha"]);

            if(usuario != null){
                HttpContext.Session.SetString("idUsuario", usuario.Id.ToString());
                return RedirectToAction ("Cadastrar", "Transacao");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View ();
        }

        [HttpGet]
        public IActionResult Listar () {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

            ViewData["Usuarios"] = usuarioRepositorio.Listar();

            return View ();
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Usuário excluído";

            return RedirectToAction ("Listar");
        }
    
        [HttpGet]
        public IActionResult Editar(int id){

            if(id == 0){
                TempData["Mensagem"] = "Informe um usuário para editar";
                return RedirectToAction("Listar");
            }

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.BuscarPorId(id);

            if(usuario != null){
                ViewBag.Usuario = usuario;
            } else {
                TempData["Mensagem"] = "Usuário não encontrado";
                return RedirectToAction("Listar");
            }
            
            return View();
        }
    
        [HttpPost]
        public IActionResult Editar(IFormCollection form){
            //Declara um objeto UsuarioModel e atribui os valores do form
            UsuarioModel usuario = new UsuarioModel(
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"])
            );

            //Cria um objeto UsuarioRepositorio e edita
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Editar(usuario);

            TempData["Mensagem"] = "Usuário editado";

            return RedirectToAction("Listar");
        }
    }
}





 */



