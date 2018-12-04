using System;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Models {
    public class ComentarioModel {
        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public bool Aprovado { get; set; } //true=aprovado, false=aguardando, deletar=some do DB
        public string NomeUsuario { get; set; }

        public ComentarioModel () {

        }

        public ComentarioModel(int id, string descricao, DateTime dataCriacao, bool aprovado, string nomeUsuario)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.DataCriacao = dataCriacao;
            this.Aprovado = aprovado;
            this.NomeUsuario = nomeUsuario;

            // ConfigurarTexto();
        }

// //Esse metodo para ver se da problema na hora de salvar comentarios
        // public void ConfigurarTexto()
        // {
        //     while (Descricao.Contains("\n"))
        //     {
        //         Texto = Texto.Replace("\n", "\\r");
        //     }
        // }

        // public void NormalizarCaracteres()
        // {
        //     while (Texto.Contains("\\br"))
        //     {
        //         Texto = Texto.Replace("\\br", "\n");
        //     }
        // }

        // public ComentarioModel(string texto, bool aprovado, string nomeUsuario) : this(0, texto, DateTime.Now, aprovado, nomeUsuario)
        // {}

        // public ComentarioModel(int id, string texto, DateTime dataCriacao, bool aprovado) : this(id, texto, dataCriacao, aprovado, null)
        // {}
        
    }
}
