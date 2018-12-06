using System;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Models {
    public class ComentarioModel {
        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public bool Aprovado { get; set; } //true=aprovado, false=aguardando, deletar=some do DB
        public string NomeUsuario { get; set; }
        
        // public string Escrita { get; set; }

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


/*



using System;
 namespace Senai.Projeto.Carfel.CheckPoint.MVC.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }
         public bool Aprovado { get; set; }
        public string nomeUsuario { get; set; }
         public ComentarioModel(int id, string texto, DateTime dataCriacao, bool aprovado, string nomeUsuario)
        {
            this.Id = id;
            this.Texto = texto;
            this.DataCriacao = dataCriacao;
            this.Aprovado = aprovado;
            this.nomeUsuario = nomeUsuario;
             EscaparCaracteresTexto();
        }
         public void EscaparCaracteresTexto()
        {
            while (Texto.Contains("\n"))
            {
                Texto = Texto.Replace("\n", "\\r");
            }
        }
         public void NormalizarCaracteres()
        {
            while (Texto.Contains("\\br"))
            {
                Texto = Texto.Replace("\\br", "\n");
            }
        }
         public ComentarioModel() : this (0, null, DateTime.Now, false, null)
        {}
         public ComentarioModel(string texto, bool aprovado, string nomeUsuario) : this(0, texto, DateTime.Now, aprovado, nomeUsuario)
        {}
         public ComentarioModel(int id, string texto, DateTime dataCriacao, bool aprovado) : this(id, texto, dataCriacao, aprovado, null)
        {}
        
    }

 */
        
    }
}
