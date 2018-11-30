using System;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Models {
    public class ComentarioModel {
        public int Id { get; set; }
        public UsuarioModel usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }

        public bool Aprovado { get; set; } //true=aprovado, false=aguardando, deletar=some do DB

        public ComentarioModel () {

        }

    }
}