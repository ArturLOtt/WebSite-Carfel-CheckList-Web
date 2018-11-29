using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Controllers
{
    public class ComentarioController : Controller
    {
        

// using System;
// using System.IO;
// using Microsoft.AspNetCore.Http;


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
            ComentarioModel tarefa = new ComentarioModel ();
            tarefa.Id = contador + 1;
            tarefa.Nome = form["nome"];
            tarefa.Descricao = form["descricao"];
            tarefa.Tipo = form["tipo"];
            // tarefa.usuario;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.Aprovado = false;

            using (StreamWriter sw = new StreamWriter ("tarefaDB.txt", true)) {
                sw.WriteLine ($"{tarefa.Id};{tarefa.Nome};{tarefa.Descricao};{tarefa.Tipo};{tarefa.IdUsuario};{tarefa.DataCriacao}");
            }

            ViewBag.Mensagem = "Tarefa cadastrada";

            return View ();

        }

    }
}





    }
}