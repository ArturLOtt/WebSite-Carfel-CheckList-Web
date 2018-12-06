using System.IO;
using Microsoft.AspNetCore.Http;
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Repositorio {
    public class ComentarioRepositorio {

        public ComentarioModel Criar (ComentarioModel comentario) {

            if (File.Exists ("comentarioDB.txt")) {

                comentario.Id = File.ReadAllLines ("comentarioDB.txt").Length + 1;
            } else {
                comentario.Id = 1;
            }
            UsuarioModel usuario = new UsuarioModel ();

            using (StreamWriter sw = new StreamWriter ("comentarioDB.txt", true)) {
                sw.WriteLine ($"{comentario.Id};{comentario.Descricao};{comentario.DataCriacao};{comentario.Aprovado};{comentario.NomeUsuario}");
            }

            return comentario;
        }
    }
}