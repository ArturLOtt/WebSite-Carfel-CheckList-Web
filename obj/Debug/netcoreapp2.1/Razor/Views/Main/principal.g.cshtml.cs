#pragma checksum "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664bd3f964527499e82bab63131f02ccb7e36d82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_principal), @"mvc.1.0.view", @"/Views/Main/principal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/principal.cshtml", typeof(AspNetCore.Views_Main_principal))]
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
#line 1 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\principal.cshtml"
using Senai.Sistema.Carfel.ProjetoFinalDezoito.Models;

#line default
#line hidden
#line 2 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\principal.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664bd3f964527499e82bab63131f02ccb7e36d82", @"/Views/Main/principal.cshtml")]
    public class Views_Main_principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\principal.cshtml"
 if(Context.Session.GetString("emailUsuario") == null){
Layout = "MasterPageDeslogado";
} else {
if (Context.Session.GetString("emailUsuario") == "23@23.com")
{
Layout = "MasterPageADMLogado";
} else {
Layout = "MasterPageLogado";
}
}

#line default
#line hidden
            BeginContext(339, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(359, 113, true);
                WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/CSS/style-princ.css\">\r\n<link rel=\"stylesheet\" href=\"/CSS/carousel-princip.css\">\r\n");
                EndContext();
            }
            );
            BeginContext(475, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\principal.cshtml"
  
ViewBag.Title = "Carfel -- Pagina Principal";

#line default
#line hidden
            BeginContext(531, 2252, true);
            WriteLiteral(@"
<main>

<div style=""height: 80%; display: flex; flex-direction: column;>
    <div class=""standart"">

        <div class=""product"">
            <div class=""figure"">
                <img src=""/imagens/carfel-basic2.png"" alt=""plano checkpoint standart"">
                <div class=""caption"">
                    <div class=""about"">
                        <h3>Standart Edition</h3>
                        <p>R$29,99</p>
                    </div>
                    <!-- fim div about-->
                </div>
                <!-- fim div about -->
            </div>
        </div>
    </div>
</div>
</div>

<div class=""bd"">
<div class=""containerx"">
<ul>
    <li>
        <input type=""radio"" checked=""checked"" name=""slide"">
        <div class=""slidex"">
            <img src=""http://picsum.photos/262"">
            <div class=""contentx"">
                <h2>Slide One</h2>
                <p>lorem ipsum comentario</p>
            </div>
        </div>
    </li>
    <li>
        <input");
            WriteLiteral(@" type=""radio"" name=""slide"">
        <div class=""slidex"">
            <img src=""http://picsum.photos/462"">
            <div class=""contentx"">
                <h2>Slide Two</h2>
                <p>lorem ipsum comentario</p>
            </div>
        </div>
    </li>
    <li>
        <input type=""radio"" name=""slide"">
        <div class=""slidex"">
            <img src=""http://picsum.photos/412"">
            <div class=""contentx"">
                <h2>Slide Three</h2>
                <p>lorem ipsum comentario</p>
            </div>
        </div>
    </li>
    <li>
        <input type=""radio"" name=""slide"">
        <div class=""slidex"">
            <img src=""http://picsum.photos/233"">
            <div class=""contentx"">
                <h2>Slide Four</h2>
                <p>lorem ipsum comentario</p>
            </div>
        </div>
    </li>
    <li>
        <input type=""radio"" name=""slide"">
        <div class=""slidex"">
            <img src=""http://picsum.photos/115"">
            <di");
            WriteLiteral("v class=\"contentx\">\r\n                <h2>Slide Five</h2>\r\n                <p>lorem ipsum comentario</p>\r\n            </div>\r\n        </div>\r\n    </li>\r\n</ul>\r\n</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</main>");
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
