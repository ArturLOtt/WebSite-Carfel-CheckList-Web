#pragma checksum "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Comentario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bdbac52a872d06e67936da670810ed60f199267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Cadastrar), @"mvc.1.0.view", @"/Views/Comentario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Cadastrar.cshtml", typeof(AspNetCore.Views_Comentario_Cadastrar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Comentario\Cadastrar.cshtml"
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

#line default
#line hidden
#line 2 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Comentario\Cadastrar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bdbac52a872d06e67936da670810ed60f199267", @"/Views/Comentario/Cadastrar.cshtml")]
    public class Views_Comentario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 245, true);
            WriteLiteral("\r\n<!--{\r\nif(Context.Session.GetString(\"idUsuario\") == null){\r\nLayout = \"MasterPageDeslogado\";\r\n} else {\r\nif (Context.Session.GetString(\"idUsuario\") == \"1\" )\r\n{\r\nLayout = \"MasterPageADMLogado\";\r\n} else {\r\nLayout = \"MasterPageLogado\";\r\n}\r\n}-->\r\n\r\n");
            EndContext();
#line 16 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Comentario\Cadastrar.cshtml"
 if(@ViewBag.UsuarioLogado == null){
    Layout = "MasterPageDeslogado";
    } else {
    if (@ViewBag.AdminBool == true)
    {
        Layout = "MasterPageADMLogado";
    } else {
        Layout = "MasterPageLogado";
    }
}

#line default
#line hidden
            BeginContext(573, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Comentario\Cadastrar.cshtml"
  
    ViewBag.Title = "Carfel -- Cadastro de Comentarios";

#line default
#line hidden
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(658, 54, true);
                WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/Css/style-form.css\">\r\n");
                EndContext();
            }
            );
            BeginContext(715, 2571, true);
            WriteLiteral(@"
<main>

    <section id=""comentarios"" style=""visibility:hidden;"">
        <h1>Area dos Comentários</h1>
        <!-- <h2>ViewBag.Mensagem</h2> -->

        <form method=""POST"" action=""/Comentario/Cadastrar"">
            <!-- <textarea>//usuario</textarea> -->
        </form>

        <table>
            <thead>
                <tr>
                    <td>Nome</td>
                    <td>E-mail</td>
                    <td>Data de nascimento</td>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>

        <form action=""/Comentario/Cadastrar"" method=""POST"">
            <label>Fazer um novo comentario
                <input type=""text"" name=""depoimento"" required>
            </label>

            <input type=""submit"" value=""Enviar"">
        </form>

        <!-- ViewBag.Mensagem -->




        foreach(ComentarioModel comentario in ViewData[""Comentarios""] as List<ComentarioModel>){
            <div class=""comment-main-level");
            WriteLiteral(@""">
                <!-- Avatar -->
                <div class=""comment-avatar""><img src=""https://png2.kisspng.com/sh/a842adb43f8dd35c071d93865c0c99d1/L0KzQYm3VsI2N6F8iJH0aYP2gLBuTfNwdaF6jNd7LXnmf7B6TfF3aaVmip9rdYPsfrb6k71kd551jeZucj32f7f7lBFzbV56i9d7LXH5ccXokr02amQ1UalvY3TpRrW7Ub42OWc4T6o7NEG4QoqCUcEzQWMASac7LoDxd1==/kisspng-computer-icons-avatar-business-computer-software-user-avatar-5b3097fcdf6d41.5163782415299112929152.png""
                        alt=""""></div>
                <!-- Contenedor del Comentario -->
                <div class=""comment-box"">
                    <div class=""comment-head"">
                        <h6 class=""comment-name by-author""><a>comentario.nomeUsuario</a></h6>
                        <span>comentario.DataCriacao</span>
                        <i class=""fa fa-times""></i>
                        <i class=""fa fa-heart""></i>
                    </div>
                    <div class=""comment-content"">
                        comentario.Texto
                    </div");
            WriteLiteral(@">
                </div>
            </div>
            <br>
            }


    </section>


    <section>

                <div>
                    <!-- Avatar -->
                    <div class=""comment-avatar""><img src=""http://picsum.photos/392""
                            alt=""Usuario"">
                    </div>
                    <!-- Contenedor del Comentario -->
                    <form action=""/Comentario"" method=""Post"">
                        <div>
                            <h6><a>");
            EndContext();
            BeginContext(3287, 40, false);
#line 105 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Comentario\Cadastrar.cshtml"
                              Write(Context.Session.GetString("nomeUsuario"));

#line default
#line hidden
            EndContext();
            BeginContext(3327, 511, true);
            WriteLiteral(@"</a></h6>
                            <span>Data do Comentário</span>
                            <i class=""fa fa-times""></i>
                            <i class=""fa fa-heart""></i>
                        </div>
                        <textarea name=""texto"" class=""formul textinho4""></textarea>
                        <button type=""submit"" formul botaozinho btn>Enviar</button>
                    </form>
                </div>

    </section>

</main>

<p>Start</p>
<p>Middle</p>
<P>End</P>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
