#pragma checksum "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af64c0b9179449f7e8891b9de23ac1cb25ce8053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af64c0b9179449f7e8891b9de23ac1cb25ce8053", @"/Views/Usuario/Login.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Usuario\Login.cshtml"
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
            BeginContext(236, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Usuario\Login.cshtml"
  
    ViewBag.Title = "Carfel -- Login";

#line default
#line hidden
            BeginContext(285, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(304, 69, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/CSS/login.css\" type=\"text/css\">\r\n");
                EndContext();
            }
            );
            BeginContext(376, 465, true);
            WriteLiteral(@"
<main>
<h1>Login</h1>

<form action=""/Usuario/Login"" method=""POST"">
    <label>Email
        <input type=""text"" name=""email"" required=""true"" placeholder=""Insira seu email"">
    </label>
    <label>Senha
        <input type=""password"" name=""senha"" required=""true"" placeholder=""Insira sua senha"">
    </label>

    <input type=""submit"" value=""Entrar"">
    <a href=""\Usuario\Cadastrar"">
        <p>Cadastro de Usuario</p>
    </a>
</form>
</main>

");
            EndContext();
            BeginContext(842, 16, false);
#line 38 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Usuario\Login.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
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
