#pragma checksum "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Devis\Etapes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3436a74b7e8eca0f1c232ef95d7a4bf8fc32d89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devis_Etapes), @"mvc.1.0.view", @"/Views/Devis/Etapes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Devis/Etapes.cshtml", typeof(AspNetCore.Views_Devis_Etapes))]
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
#line 1 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\_ViewImports.cshtml"
using OutilsActualisation;

#line default
#line hidden
#line 2 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\_ViewImports.cshtml"
using OutilsActualisation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3436a74b7e8eca0f1c232ef95d7a4bf8fc32d89", @"/Views/Devis/Etapes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab37d2a19db97e1812d2a0e685ff62998308c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Devis_Etapes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1151, true);
            WriteLiteral(@"<div style=""width:15vw; position:absolute; left:0; top: calc(8.5vw + 2vh); margin-top: 20px;"">
    <div onclick=""AjaxFill('/Devis/ConditionAdmission', '#ContentContainer', false); ChangeSelect('smallstep','selected', $(event.target));"" class=""smallstep selected"">Conditions d'admission</div>
    <div onclick=""AjaxFill('/Devis/AnalyseProfession', '#ContentContainer', false); ChangeSelect('smallstep','selected', $(event.target));"" class=""smallstep"">Analyse de la profession</div>
    <div onclick=""AjaxFill('/Devis/UniteHeure', '#ContentContainer', false); ChangeSelect('smallstep','selected', $(event.target));"" class=""smallstep"">Unités et heures</div>
    <div onclick=""AjaxFill('/Devis/Finalite', '#ContentContainer', false); ChangeSelect('smallstep','selected', $(event.target));"" class=""smallstep"">Finalités</div>
    <div onclick=""AjaxFill('/Devis/Competence', '#ContentContainer', false); ChangeSelect('smallstep','selected', $(event.target));"" class=""smallstep"">Liste des compétences</div>
</div>
<div id=""Co");
            WriteLiteral("ntentContainer\" style=\"margin-left: 15vw; position:relative; height: calc(100vh - (1vh + 11.25vw + 111px));\">\r\n    \r\n</div>\r\n\r\n");
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
