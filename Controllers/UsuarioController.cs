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
            return RedirectToAction ("Login");
        }

        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (email: form["email"], senha:form["senha"]);

            using (StreamReader sr = new StreamReader ("usuarioDB.txt")) {
                while (!sr.EndOfStream) {
                    string[] linha = sr.ReadLine ().Split (";");

                    if (linha[2] == usuario.Email && linha[3] == usuario.Senha) {
                        HttpContext.Session.SetString ("emailUsuario", usuario.Email);
                        return RedirectToAction ("Cadastrar", "Comentario");
                    }
                }
            }

            ViewBag.Mensagem = "Usuário Inválido";

            return View ();
        }


    //     [HttpPost]
    //     public IActionResult Login(IFormCollection form){
    //         UsuarioModel usuario = new UsuarioModel( email: form["email"], senha: form["senha"]);

    //         UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
    //         UsuarioModel usuarioModel = usuarioRepositorio.EmailSenha(usuario.Email, usuario.Senha);

    //         if(usuarioModel != null){
    //             if(usuarioModel.Email.Contains("admin@carfel.com")){
    //             HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
    //             HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
    //             HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());
    //             HttpContext.Session.SetString("tipoUsuario", usuarioModel.Administrador.ToString());
        
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
        public IActionResult Deslogar(){
            HttpContext.Session.Clear();
            return RedirectToAction ("Principal");
        }

    }

}