#pragma checksum "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Shared\MasterPageLogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9109ea64b16c0114c66ff879da259f05748a015c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageLogado), @"mvc.1.0.view", @"/Views/Shared/MasterPageLogado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageLogado.cshtml", typeof(AspNetCore.Views_Shared_MasterPageLogado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9109ea64b16c0114c66ff879da259f05748a015c", @"/Views/Shared/MasterPageLogado.cshtml")]
    public class Views_Shared_MasterPageLogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 36, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"pt-BR\">\n");
            EndContext();
            BeginContext(36, 740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d4e7210dcc442c6aed6d6ec80a2481f", async() => {
                BeginContext(42, 125, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <title>| Check Point - Bem-Vindo ");
                EndContext();
                BeginContext(168, 21, false);
#line 6 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Shared\MasterPageLogado.cshtml"
                                Write(ViewBag.UsuarioLogado);

#line default
#line hidden
                EndContext();
                BeginContext(189, 155, true);
                WriteLiteral(" |</title>\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <link href=\"/CSS/style.css\" rel=\"stylesheet\" type=\"text/css\">\n     ");
                EndContext();
                BeginContext(345, 40, false);
#line 9 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Shared\MasterPageLogado.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(385, 384, true);
                WriteLiteral(@"
    <!-- <link href=""/JS/style.js"" rel=""stylesheet"" type=""text/css""> -->
    <link href=""https://fonts.googleapis.com/css?family=M+PLUS+Rounded+1c|Work+Sans"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU""
        crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(776, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(777, 4708, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e9b21141a784330ae78a99689558a6c", async() => {
                BeginContext(783, 2220, true);
                WriteLiteral(@"
    <!--<a href=""/Usuario/Listar"">Listar</a>
    <a href=""/Usuario/Cadastro"">Cadastrar</a>
    <a href=""/Usuario/Login"">Login</a>
     <a href=""""></a> -->

    <header>

        <div class=""azulao"" style=""background-color: red"">

            <nav>
                <ul>
                    <li>
                        <a href=""\Main\principal"">
                            Página Principal</a>
                    </li>
                    <p> | </p>
                    <li>
                        <a href=""\Main\formulario"">
                            Formulário de Contato</a>
                    </li>
                    <p> | </p>
                    <li>
                        <a href=""\Main\about"">
                            Sobre Nós</a>
                    </li>
                    <p> | </p>
                    <li>
                        <a href=""\Main\faq"">
                            Fale Conosco</a>
                    </li>
                    <p> | </p>
                    <li>
                ");
                WriteLiteral(@"        <a href=""\Main\Principal"">
                            Sair TODO</a>
                    </li>
                    <p> | </p>
                    <li>
                        <a href=""\Comentario\Cadastrar"">
                            Comentarios</a>
                    </li>

                </ul>
            </nav>
            <h1> | | </h1>
            <div class=""clock"">
                <a href=""#"">
                    <img src=""/imagens/logo-ativo1.png"" alt=""logo da empresa"">
                </a>

            </div>
            <div class=""sec"">
                <img src=""/imagens/logo-ativo3.png"" class=""sec_img"" alt=""logo da empresa"">
            </div>

        </div>

        <div class=""azuzinho"">

            <p class=""utwisi"">
                &emsp;&emsp;Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt.
                <br> &emsp;&emsp; Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl
               ");
                WriteLiteral(" ut aliquip ex ea commodo consequat.\n            </p>\n            <p id=\"carfectellus\">\n                Telefone: +55 XX 4321 9876 </p>\n\n        </div>\n\n    </header>\n\n    ");
                EndContext();
                BeginContext(3004, 12, false);
#line 86 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Shared\MasterPageLogado.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3016, 2462, true);
                WriteLiteral(@"

    <footer>
        <div class=""upper"">

            <div class=""upper-list-1"">

                <ul>
                    <li>
                        <a href=""\Main\princip"">Página Principal</a>

                    </li>

                    <li>
                        <a href=""#"">Termos de Uso</a>

                    </li>

                </ul>

            </div>

            <div class=""ot1"">


                <ul>
                    <li>
                        <a href=""#"">
                            <i class=""fab fa-facebook-f"" aria-hidden=""true""></i>

                            <span>Facebook</span>
                        </a>
                    </li>

                    <li>
                        <a href=""#"">
                            <i class=""fab fa-twitter"" aria-hidden=""true""></i>

                            <span>Twitter</span>
                        </a>
                    </li>

                    <li>
                        <a href=""#"">
                            <i class");
                WriteLiteral(@"=""fab fa-google-plus-g"" aria-hidden=""true""></i>
                            <span>Google+</span>
                        </a>
                    </li>

                    <li>
                        <a href=""#"">
                            <i class=""fab fa-linkedin"" aria-hidden=""true""></i>
                            <span>Linkedin</span>
                        </a>
                    </li>

                    <li>
                        <a href=""#"">
                            <i class=""fab fa-instagram"" aria-hidden=""true""></i>
                            <span>Instagram</span>
                        </a>
                    </li>
                </ul>


            </div>

            <div class=""upper-list-2"">



                <ul>
                    <li>
                        <a href=""\Main\faq"">FAQ</a>

                    </li>

                    <li>
                        <a href=""#"">Política de Privacidade</a>

                    </li>

                </ul>

            </div>

    ");
                WriteLiteral(@"    </div>

        <div class=""bottower"">
            <ul>
                <li>
                    Telefone: +55 XX 4321 9876
                </li>
                <li>
                    Endereço: Rua Barão de Limeira, 428, São Paulo, SP, Brasil
                </li>
                <li>
                    © 2018 All rights Reserved
                </li>

            </ul>


        </div>

    </footer>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5485, 8, true);
            WriteLiteral("\n</html>");
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
