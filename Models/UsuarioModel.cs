namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Models {
    public class UsuarioModel {

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int Id { get; set; }
        
        public string Tipo { get; set; } //(usuário/admin)

        public UsuarioModel()
        {
            
        }

        public UsuarioModel(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }

        public UsuarioModel(string nome, string email, string senha, string tipo)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Tipo = Tipo;
        }

        public UsuarioModel(int id, string nome, string email, string senha, string tipo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Tipo = Tipo;
        }

    }
}