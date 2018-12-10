using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public List<ComentarioModel> ListarADM () => LerTxtNaoAprovado ();
        public List<ComentarioModel> Listar () => LerTxtAprovado ();
        private List<ComentarioModel> LerTxtNaoAprovado () {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            if (File.Exists ("comentarioDB.txt")) {
                string[] lines = File.ReadAllLines ("comentarioDB.txt");

                foreach (string line in lines) {
                    if (string.IsNullOrEmpty (line)) {

                        continue;
                    }

                    string[] dadosLine = line.Split (';');

                    if (!Boolean.Parse (dadosLine[3])) {
                        ComentarioModel comentario = new ComentarioModel (
                            id: int.Parse (dadosLine[0]),
                            descricao: (dadosLine[1]),
                            dataCriacao: DateTime.Parse (dadosLine[2]),
                            aprovado: Boolean.Parse (dadosLine[3]),
                            nomeUsuario: (dadosLine[4])
                        );
                        lsComentarios.Add (comentario);
                    }
                }
            }
            return lsComentarios .OrderBy (x => x.DataCriacao).Reverse ().ToList () ;
        }
        private List<ComentarioModel> LerTxtAprovado () {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            if (File.Exists ("comentarioDB.txt")) {
                string[] lines = File.ReadAllLines ("comentarioDB.txt");

                foreach (string line in lines) {
                    if (string.IsNullOrEmpty (line)) {

                        continue;
                    }

                    string[] dadosLine = line.Split (';');

                    if (Boolean.Parse (dadosLine[3])) {
                        ComentarioModel comentario = new ComentarioModel (
                            id: int.Parse (dadosLine[0]),
                            descricao: (dadosLine[1]),
                            dataCriacao: DateTime.Parse (dadosLine[2]),
                            aprovado: Boolean.Parse (dadosLine[3]),
                            nomeUsuario: (dadosLine[4])
                        );
                        lsComentarios.Add (comentario);
                    }
                }
            }
            return lsComentarios .OrderBy (x => x.DataCriacao).Reverse ().ToList () ;
        }
        public static void Excluir(int id)
        {
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("comentarioDB.txt");

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

            File.WriteAllLines("comentarioDB.txt", linhas);
        }
        public static void Aprovar(int id)
        {
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("comentarioDB.txt");

            //Lê cada registro no DataBase
            for (int i = 0; i < linhas.Length; i++)
            {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split(';');

                if (id.ToString() == dadosDaLinha[0]) {
                    
                    linhas[i] = $"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};True;{dadosDaLinha[4]};";
                    continue;
                }
            }  

            File.WriteAllLines("comentarioDB.txt", linhas);
        }

    }
}