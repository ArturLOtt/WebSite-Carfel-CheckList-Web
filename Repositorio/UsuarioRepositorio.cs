namespace Senai.Sistema.Carfel.ProjetoFinalDezoito.Repositorio
{
    public class UsuarioRepositorio
    {
        




// using System.Collections.Generic;
// using System.IO;
// using Senai.Projeto.Carfel.CheckPoint.MVC.Models;


//         public UsuarioModel EmailSenha(string email, string senha)
//         {
//             List<UsuarioModel> usuariosCadastrados = LerCSV();

//             foreach (UsuarioModel usuario in usuariosCadastrados)
//             {
//                 if (usuario.Email == email && usuario.Senha == senha)
//                 {
//                     return usuario;
//                 }
//             }

//             return null;
//         }

//         public List<UsuarioModel> Listar() => LerCSV();
//         private List<UsuarioModel> LerCSV()
//         {
//             List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();

//             string[] linhas = File.ReadAllLines("usuarios.csv");

//             foreach (string linha in linhas)
//             {
//                 if(string.IsNullOrEmpty(linha)){
//                     continue;
//                 }

//                 string[] dadosDaLinha = linha.Split(';');

//                 UsuarioModel usuario = new UsuarioModel
//                 (
//                     id: int.Parse(dadosDaLinha[0]),
//                     nome: dadosDaLinha[1],
//                     email: dadosDaLinha[2],
//                     senha: dadosDaLinha[3]
                    
//                 );

//                 lsUsuarios.Add(usuario);
//             }       
//             return lsUsuarios;     
//         }
//         public UsuarioModel Cadastrar(UsuarioModel usuario)
//         {
            
//             if(File.Exists("usuarios.csv")){
//                 usuario.Id = System.IO.File.ReadAllLines("usuarios.csv").Length+1;
//             }else{
//                 using(StreamWriter sw = new StreamWriter("usuarios.csv",true)){
//                 usuario.Administrador = true;
//                 sw.WriteLine($"1;Administrador;admin@carfel.com;admin;1;");
//             }
//                 usuario.Id = 2;   
//             }
//             using(StreamWriter sw = new StreamWriter("usuarios.csv",true)){
//                 sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};0");
//             }
//             return usuario;
//         }

//         public UsuarioModel BuscarPorId(int id)
//         {
//             string[] linhas = System.IO.File.ReadAllLines ("usuarios.csv");

//             for (int i = 0; i < linhas.Length; i++) {
//                 if (string.IsNullOrEmpty (linhas[i])) {
//                     continue;
//                 }
//                 string[] dados = linhas[i].Split (';');

//                 if (dados[0] == id.ToString ()) {
//                     UsuarioModel usuario = new UsuarioModel
//                     (
//                     id: int.Parse (dados[0]),
//                     nome: dados[1],
//                     email: dados[2],
//                     senha: dados[3],
//                     administrador: (dados[4] == "0" ? false : true)
//                     );

//                     return usuario;
//                 }

//             }
//             return null;
//         }
//     }
// }










    }
}