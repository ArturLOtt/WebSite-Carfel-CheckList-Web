namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Models {
    public class UsuarioModel {

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public int Id { get; set; }

        public bool Cliente { get; set; } //(cliente/admin)

        public UsuarioModel()
        {
            
        }

        public UsuarioModel(string email, string senha)
        {
            this.Email = email;
            this.Senha = senha;
        }

        public UsuarioModel(string nome, string email, string senha, bool cliente)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Cliente = cliente;
        }

        public UsuarioModel(int id, string nome, string email, string senha, bool cliente)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Cliente = cliente;
        }

    }
}