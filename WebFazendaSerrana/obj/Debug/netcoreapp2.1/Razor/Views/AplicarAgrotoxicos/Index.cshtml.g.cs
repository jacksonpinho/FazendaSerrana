#pragma checksum "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e77103b095d323d84633c3dbf4503c9e36a409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AplicarAgrotoxicos_Index), @"mvc.1.0.view", @"/Views/AplicarAgrotoxicos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AplicarAgrotoxicos/Index.cshtml", typeof(AspNetCore.Views_AplicarAgrotoxicos_Index))]
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
#line 1 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\_ViewImports.cshtml"
using WebFazendaSerrana;

#line default
#line hidden
#line 2 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\_ViewImports.cshtml"
using WebFazendaSerrana.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e77103b095d323d84633c3dbf4503c9e36a409", @"/Views/AplicarAgrotoxicos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b0fd1359c842a15e863c3b011acd3cac37c0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_AplicarAgrotoxicos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebFazendaSerrana.Models.AplicarAgrotoxico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(107, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(136, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce8e85c794ad49ce8873a6ed18f53930", async() => {
                BeginContext(159, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(173, 129, true);
            WriteLiteral("\r\n</p>\r\n\r\n<h3>Aplicações Preventivas</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(303, 59, false);
#line 19 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaPlantio.DataPlantio));

#line default
#line hidden
            EndContext();
            BeginContext(362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(418, 41, false);
#line 22 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Praga));

#line default
#line hidden
            EndContext();
            BeginContext(459, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(515, 47, false);
#line 25 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdAplicado));

#line default
#line hidden
            EndContext();
            BeginContext(562, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
         foreach (var item in Model)
        {

            if (item.Tipo.Equals("PREVENTIVA"))
            {


#line default
#line hidden
            BeginContext(765, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(838, 58, false);
#line 39 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AreaPlantio.DataPlantio));

#line default
#line hidden
            EndContext();
            BeginContext(896, 84, true);
            WriteLiteral("\r\n                    </td>\r\n   \r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(981, 52, false);
#line 43 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Praga.NomePopular));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1115, 46, false);
#line 47 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QtdAplicado));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 103, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    \r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1265, 87, false);
#line 52 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { IdAplicarAgrotoxico = item.IdAplicarAgrotoxico }));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1381, 93, false);
#line 53 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { IdAplicarAgrotoxico = item.IdAplicarAgrotoxico }));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1503, 91, false);
#line 54 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { IdAplicarAgrotoxico = item.IdAplicarAgrotoxico }));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 57 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1672, 146, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n<h3>Aplicações Corretivas</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1819, 40, false);
#line 69 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1915, 59, false);
#line 72 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AreaPlantio.DataPlantio));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2030, 41, false);
#line 75 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Praga));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2127, 47, false);
#line 78 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdAplicado));

#line default
#line hidden
            EndContext();
            BeginContext(2174, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 84 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
         foreach (var item in Model)
        {

            if (item.Tipo.Equals("CORRETIVA"))
            {


#line default
#line hidden
            BeginContext(2376, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2449, 39, false);
#line 92 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2568, 58, false);
#line 95 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AreaPlantio.DataPlantio));

#line default
#line hidden
            EndContext();
            BeginContext(2626, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2706, 52, false);
#line 98 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Praga.NomePopular));

#line default
#line hidden
            EndContext();
            BeginContext(2758, 81, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2840, 46, false);
#line 102 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QtdAplicado));

#line default
#line hidden
            EndContext();
            BeginContext(2886, 103, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    \r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2990, 87, false);
#line 107 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { IdAplicarAgrotoxico = item.IdAplicarAgrotoxico }));

#line default
#line hidden
            EndContext();
            BeginContext(3077, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3106, 93, false);
#line 108 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { IdAplicarAgrotoxico = item.IdAplicarAgrotoxico }));

#line default
#line hidden
            EndContext();
            BeginContext(3199, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3228, 91, false);
#line 109 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { IdAplicarAgrotoxico = item.IdAplicarAgrotoxico }));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 112 "E:\PROGRAMACAO WEB\FazendaSerrana\FazendaSerrana\WebFazendaSerrana\Views\AplicarAgrotoxicos\Index.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3397, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebFazendaSerrana.Models.AplicarAgrotoxico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
