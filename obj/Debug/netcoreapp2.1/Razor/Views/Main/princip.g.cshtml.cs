#pragma checksum "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\princip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f050bf952d5ee033103a33a58330f0ebd16cab58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_princip), @"mvc.1.0.view", @"/Views/Main/princip.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/princip.cshtml", typeof(AspNetCore.Views_Main_princip))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f050bf952d5ee033103a33a58330f0ebd16cab58", @"/Views/Main/princip.cshtml")]
    public class Views_Main_princip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(40, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a41209702b7469b9a37d19c9dd8e0ba", async() => {
                BeginContext(46, 281, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""/Css/style.css"">
    <link rel=""stylesheet"" href=""/Css/style-princ.css"">
    

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
            BeginContext(334, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 14 "C:\Users\22972804830\Documents\Projetos Csharp\AulaD1\Senai.Sistema.Carfel.ProjetoFinalDezoito\Views\Main\princip.cshtml"
  
    ViewBag.Title = "Carfel -- Pagina Principal";
    Layout = "MasterPagePrincipal";

#line default
#line hidden
            BeginContext(433, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(437, 2444, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afcde36a8853480b953909b2cf90d04c", async() => {
                BeginContext(443, 2431, true);
                WriteLiteral(@"

    <main>

        <div class=""standart"">

            <div class=""product"">
                <div class=""figure"">
                    <img src=""Imagens/carfel-basic2.png"" alt=""plano checkpoint standart"">
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


        <div class=""container"">

            <input type=""radio"" name=""images"" id=""i1"">
            <input type=""radio"" name=""images"" id=""i2"">
            <input type=""radio"" name=""images"" id=""i3"">
            

            <div class=""slide_img"" style=""overflow-y: auto;"">
                <div id=""one"">
                    <input type=""text"" name=""comentador"" disabled>
                    <i");
                WriteLiteral(@"mg src=""https://picsum.photos/244"" alt=""usuario1"">
                    <label for=""i3"" class=""pre""></label>
                    <label for=""i2"" class=""nxt""></label>
                    <input type=""text"" name=""comentario"" disabled>
                </div>
            </div>
            <div>
                <div id=""two"">
                    <input type=""text"" name=""comentador"" disabled>
                    <img src=""https://picsum.photos/274"" alt=""usuario2"">
                    <label for=""i3"" class=""pre""></label>
                    <label for=""i2"" class=""nxt""></label>
                    <input type=""text"" name=""comentario"" disabled>
                </div>
            </div>
            <div>
                <div id=""three"">
                    <input type=""text"" name=""comentador"" disabled>
                    <label for=""i3"" class=""pre""></label>
                    <label for=""i2"" class=""nxt""></label>
                    <img src=""https://picsum.photos/149"" alt=""usuario3"">
            ");
                WriteLiteral(@"        <input type=""text"" name=""comentario"" disabled>
                </div>
            </div>

            <div class=""nav"">
                <label class=""dots"" id=""dot1"" for=""i1""></label>
                <label class=""dots"" id=""dot2"" for=""i2""></label>
                <label class=""dots"" id=""dot3"" for=""i3""></label>
            </div>

        </div>

    </main>

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
            BeginContext(2881, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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