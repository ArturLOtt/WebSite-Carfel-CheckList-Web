using System;

namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Models {
    public class ComentarioModel {
        public DateTime DataCriacao { get; set; }

        public UsuarioModel usuario { get; set; }

        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Aprovado { get; set; }


// fazer ctor



    }
}