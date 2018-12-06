using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Repositorio;

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
            // comentario.Usuario = UsuarioAutenticado;
            comentario.Descricao = form["descricao"];
            comentario.DataCriacao = DateTime.Now;
            comentario.Aprovado = false;
            comentario.NomeUsuario = HttpContext.Session.GetString("emailUsuario");

            ComentarioRepositorio comRepo = new ComentarioRepositorio();
            comRepo.Criar(comentario);

            TempData["Mensagem"] = "Comentário cadastrado com sucesso!";
            ViewBag.Mensagem = "Comentário Cadastrado";

            // using (StreamWriter sw = new StreamWriter ("comentarioDB.txt", true)) {
            //     sw.WriteLine ($"{comentario.Id};{HttpContext.Session.GetString("emailUsuario")};{comentario.Descricao};{comentario.DataCriacao};{comentario.Aprovado}");
            // }

            return View ();
        }
    
    /*
    
using Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class ComentariosController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(IFormCollection form){

            ComentarioModel comentarioModel = new ComentarioModel(texto: form["texto"],aprovado: false, nomeUsuario: HttpContext.Session.GetString("nomeUsuario"));

            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Criar(comentarioModel);

            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();
                
                TempData["Mensagem"] = "Comentário enviado para aprovação dos administradores";

            return View();
        }
        [HttpGet]
        public IActionResult AprovarComentarios(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
           
            return View();
        }

        [HttpGet]
        public IActionResult ListarEMostrar(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();
            
            return View();
        }

        [HttpGet]
        public IActionResult ComentarioDeslogado (){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            if(HttpContext.Session.GetString("tipoUsuario")== "1")
            ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();

            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ComentarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Comentario excluído";

            return RedirectToAction("AprovarComentarios");
        }

        [HttpGet]
        public IActionResult Aprovar(int id)
        {
            ComentarioRepositorio.Aprovar(id);

            TempData["Mensagem"] = "Comentario Aprovado";

            return RedirectToAction("AprovarComentarios");

        }
    }
}

*/


/*  
    

using System.Collections.Generic;
using System.Linq;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios {
    public class ComentarioRepositorio {
        public ComentarioModel Criar (ComentarioModel comentarioModel) {

            if (File.Exists ("comentarios.csv")) {
                comentarioModel.Id = System.IO.File.ReadAllLines ("comentarios.csv").Length + 1;
            } else {
                comentarioModel.Id = 1;
            }
            UsuarioModel usuario = new UsuarioModel ();

            using (StreamWriter escrever = new StreamWriter ("comentarios.csv", true)) {
                if (comentarioModel.Aprovado == false) {
                    escrever.WriteLine ($"{comentarioModel.Id};{comentarioModel.nomeUsuario};{comentarioModel.Texto};{comentarioModel.DataCriacao};0");
                }
            }
            return comentarioModel;
        }

        public List<ComentarioModel> Listar () => LerCSV ();

        public List<ComentarioModel> ListarEMostrar () => LerAprovadosDoCSV();
        public List<ComentarioModel> LerAprovadosDoCSV (){
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();
            if (File.Exists ("comentarios.csv")) {
                string[] lines = File.ReadAllLines ("comentarios.csv");

                foreach (string line in lines) {
                    if (string.IsNullOrEmpty (line)) {

                        continue;
                    }

                    string[] dadosLine = line.Split (';');
                    if(dadosLine[4] == "1"){
                        ComentarioModel comentario = new ComentarioModel (
                            id: int.Parse (dadosLine[0]),
                            nomeUsuario: dadosLine[1],
                            texto: dadosLine[2],
                            dataCriacao: DateTime.Parse (dadosLine[3]),
                            aprovado: (dadosLine[4] == "1")
                        );
                        lsComentarios.Add(comentario);
                    }

                   
                }
            } 
            return lsComentarios.OrderBy(x => x.DataCriacao).ToList();

        }   

        private List<ComentarioModel> LerCSV () {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            if (File.Exists ("comentarios.csv")) {
                string[] lines = File.ReadAllLines ("comentarios.csv");

                foreach (string line in lines) {
                    if (string.IsNullOrEmpty (line)) {

                        continue;
                    }

                    string[] dadosLine = line.Split (';');

                    if(dadosLine[4] == "0"){
                        ComentarioModel comentario = new ComentarioModel (
                            id: int.Parse (dadosLine[0]),
                            nomeUsuario: dadosLine[1],
                            texto: dadosLine[2],
                            dataCriacao: DateTime.Parse (dadosLine[3]),
                            aprovado: (dadosLine[4] == "1")
                        );
                        lsComentarios.Add(comentario);
                    }
                }
            } 
            return lsComentarios.OrderBy(x => x.DataCriacao).Reverse().ToList();
        }
        public static void Excluir(int id)
        {
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("comentarios.csv");

            //Lê cada registro no CSV
            for (int i = 0; i < linhas.Length; i++)
            {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split(';');

                if (id.ToString() == dadosDaLinha[0]) {
                    linhas[i] = "";
                    break;
                }
            }  

            File.WriteAllLines("comentarios.csv", linhas);
        }
        public static void Aprovar(int id)
        {
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("comentarios.csv");

            //Lê cada registro no CSV
            for (int i = 0; i < linhas.Length; i++)
            {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split(';');

                if (id.ToString() == dadosDaLinha[0]) {
                    
                    linhas[i] = $"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};1";
                    continue;
                }
            }  

            File.WriteAllLines("comentarios.csv", linhas);
        }
    }
}
    
    
    
    
    
    
    
    
    
     */
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
