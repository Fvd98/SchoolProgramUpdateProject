#pragma checksum "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77b590ccd399771d52328144ad8244035fba18a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competence_GroupeCompetence_Profil), @"mvc.1.0.view", @"/Views/Competence/GroupeCompetence_Profil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Competence/GroupeCompetence_Profil.cshtml", typeof(AspNetCore.Views_Competence_GroupeCompetence_Profil))]
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
#line 1 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\_ViewImports.cshtml"
using OutilsActualisation;

#line default
#line hidden
#line 2 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\_ViewImports.cshtml"
using OutilsActualisation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b590ccd399771d52328144ad8244035fba18a0", @"/Views/Competence/GroupeCompetence_Profil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab37d2a19db97e1812d2a0e685ff62998308c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Competence_GroupeCompetence_Profil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectGroupe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("$(event.target).css(\'border-color\', couleurs[$(event.target).val()])"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Competence", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GroupeCompetence_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("Alert(\'error\', xhr.responseText)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GroupeCompetence_Profil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("Alert(\'error\',\'L\\\'enregistrement a échoué.\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
  
    int increment = 1;
    string TableauCouleur = "";

#line default
#line hidden
            BeginContext(88, 32, true);
            WriteLiteral("<script>\r\n    var couleurs = {\r\n");
            EndContext();
#line 8 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
         foreach (var groupe in Model.instance.GroupeCompetence)
        {
            TableauCouleur += "'" + groupe.Id + "' : '" + groupe.Couleur + "',";
        }

#line default
#line hidden
            BeginContext(290, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 12 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
         if (TableauCouleur.Length != 0) {
            TableauCouleur.Remove(TableauCouleur.Length - 1);
        }

#line default
#line hidden
            BeginContext(408, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(417, 24, false);
#line 15 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
   Write(Html.Raw(TableauCouleur));

#line default
#line hidden
            EndContext();
            BeginContext(441, 509, true);
            WriteLiteral(@"
    };
</script>
<style>
    #selectGroupe:focus {
        outline: 0;
    }

    .th-td-repartition {
        width: 28px;
        text-align: center;
    }

    .th-td-repartition-tot {
        width: 39px;
        text-align: center;
    }

    .table-striped > tbody > tr:nth-of-type(odd) {
        background-color: #e5e5e5;
    }

    .tableD, .tableD tr th, .tableD tr td {
        border: 0;
    }
</style>
<div style=""float:right;"">
    <div style=""float:right"">
        ");
            EndContext();
            BeginContext(950, 1707, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8720cd94f54220a7e5e579daf891bb", async() => {
                BeginContext(1255, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1269, 420, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d9d17bffa945e9b264ae69e9a258c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 11, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 44 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
AddHtmlAttributeValue("", 1336, Html.Raw(Model.instance.GroupeCompetence.Count != 0?"border-color:"+Model.instance.GroupeCompetence.First().Couleur+";":""), 1336, 124, false);

#line default
#line hidden
                AddHtmlAttributeValue(" ", 1460, "display:inline-block;", 1461, 22, true);
                AddHtmlAttributeValue(" ", 1482, "border-right:0;", 1483, 16, true);
                AddHtmlAttributeValue(" ", 1498, "height:30px;", 1499, 13, true);
                AddHtmlAttributeValue(" ", 1511, "border-radius:", 1512, 15, true);
                AddHtmlAttributeValue(" ", 1526, "4px", 1527, 4, true);
                AddHtmlAttributeValue(" ", 1530, "0", 1531, 2, true);
                AddHtmlAttributeValue(" ", 1532, "0", 1533, 2, true);
                AddHtmlAttributeValue(" ", 1534, "4px;", 1535, 5, true);
                AddHtmlAttributeValue(" ", 1539, "margin-left:4px;", 1540, 17, true);
                AddHtmlAttributeValue(" ", 1556, "width:250px;", 1557, 13, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#line 44 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.selectList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1689, 5, true);
                WriteLiteral("<span");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1694, "\"", 1832, 7);
                WriteAttributeValue("", 1704, "AjaxFill(\'/Competence/GroupeCompetence_Create?idInstance=", 1704, 57, true);
#line 44 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 1761, Model.instance.Id, 1761, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 1779, "&idProfil=", 1779, 10, true);
#line 44 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 1789, ViewBag.Profil, 1789, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 1804, "\',", 1804, 2, true);
                WriteAttributeValue(" ", 1806, "\'#ModalContainer\',", 1807, 19, true);
                WriteAttributeValue(" ", 1825, "false)", 1826, 7, true);
                EndWriteAttribute();
                BeginContext(1833, 200, true);
                WriteLiteral(" class=\"btn btn-success\" style=\"display:inline-block; height:30px; line-height: 30px; padding: 0 6px 0px 7px; border-left:0; border-radius:0\"><span class=\"glyphicon glyphicon-plus\"></span></span><span");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2033, "\"", 2183, 9);
                WriteAttributeValue("", 2043, "AjaxFill(\'/Competence/GroupeCompetence_Update?idGroupe=\'", 2043, 56, true);
                WriteAttributeValue(" ", 2099, "+", 2100, 2, true);
                WriteAttributeValue(" ", 2101, "$(\'#selectGroupe\').val()", 2102, 25, true);
                WriteAttributeValue(" ", 2126, "+", 2127, 2, true);
                WriteAttributeValue(" ", 2128, "\'&idProfil=", 2129, 12, true);
#line 44 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 2140, ViewBag.Profil, 2140, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 2155, "\',", 2155, 2, true);
                WriteAttributeValue(" ", 2157, "\'#ModalContainer\',", 2158, 19, true);
                WriteAttributeValue(" ", 2176, "false)", 2177, 7, true);
                EndWriteAttribute();
                BeginContext(2184, 466, true);
                WriteLiteral(@" class=""btn btn-warning"" style=""display:inline-block; height:30px; line-height: 30px; padding: 0 6px 0px 7px; border-left:0; border-radius:0""><span class=""glyphicon glyphicon-edit""></span></span><span onclick=""$(event.target.parentElement).submit();"" class=""btn btn-danger"" style=""display:inline-block; height:30px; line-height: 30px; padding: 0 6px 0px 7px; border-left:0; border-radius:0 4px 4px 0""><span class=""glyphicon glyphicon-remove""></span></span>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Alert(\'success\', xhr.responseText); AjaxFill(\'/Competence/GroupeCompetence_Profil?id=");
#line 43 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                                                                                                                                                                                                                                                Write(ViewBag.Profil);

#line default
#line hidden
            WriteLiteral("\', \'#menu\', false);");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-success", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2657, 1018, true);
            WriteLiteral(@"
    </div>
    <div style=""float:right; line-height: 30px;"">Selectionnez un groupe de compétence : </div>
</div>
<br /> <br />
<div id=""inner_menu"">
    <table style=""width:100%!important;"" class=""tableD table-striped"">
        <thead>
            <tr>
                <th style=""background-color: #1d1f21; text-align:left!important;"">Compétence</th>
                <th style=""background-color: #1d1f21;"" class=""th-td-repartition"">S1</th>
                <th style=""background-color: #1d1f21;"" class=""th-td-repartition"">S2</th>
                <th style=""background-color: #1d1f21;"" class=""th-td-repartition"">S3</th>
                <th style=""background-color: #1d1f21;"" class=""th-td-repartition"">S4</th>
                <th style=""background-color: #1d1f21;"" class=""th-td-repartition"">S5</th>
                <th style=""background-color: #1d1f21;"" class=""th-td-repartition"">S6</th>
                <th class=""th-td-repartition-tot"">Total</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 65 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
             foreach (var Competence in Model.instance.ProfilFormationNavigation.CompetenceProfilFormation.Select(CPF => CPF.CompetenceNavigation).ToList())
            {

#line default
#line hidden
            BeginContext(3848, 81, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:left!important;\">");
            EndContext();
            BeginContext(3930, 15, false);
#line 68 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                      Write(Competence.Code);

#line default
#line hidden
            EndContext();
            BeginContext(3945, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3949, 17, false);
#line 68 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                                         Write(Competence.Enonce);

#line default
#line hidden
            EndContext();
            BeginContext(3966, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 69 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                     for (int i = 1; i <= 6; i++)
                    {
                        OutilsActualisation.AppData.HeureComp heureComp = Model.instance.HeureComp.Where(HC => HC.Competence == Competence.Code && HC.NoSession == i).FirstOrDefault();

#line default
#line hidden
            BeginContext(4232, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(4290, 2073, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b47a90f5aad64b5ea1dc0e16b743194f", async() => {
                BeginContext(4467, 40, true);
                WriteLiteral("\r\n                                <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4507, "\"", 4549, 4);
                WriteAttributeValue("", 4512, "nouveau_", 4512, 8, true);
#line 74 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4520, Html.Raw(i), 4520, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 4532, "_", 4532, 1, true);
#line 74 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4533, Competence.Code, 4533, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4550, 29, true);
                WriteLiteral(" type=\"hidden\" name=\"nouveau\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4579, "\"", 4615, 1);
#line 74 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4587, Html.Raw(heureComp == null), 4587, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4616, 74, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"NoSession\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4690, "\"", 4700, 1);
#line 75 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4698, i, 4698, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4701, 75, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"Competence\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4776, "\"", 4800, 1);
#line 76 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4784, Competence.Code, 4784, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4801, 88, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"InstanceHeureCompetence\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4889, "\"", 4915, 1);
#line 77 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4897, Model.instance.Id, 4897, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4916, 43, true);
                WriteLiteral(" />\r\n                                <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4959, "\"", 4999, 4);
                WriteAttributeValue("", 4964, "input_", 4964, 6, true);
#line 78 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4970, Html.Raw(i), 4970, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 4982, "_", 4982, 1, true);
#line 78 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 4983, Competence.Code, 4983, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5000, 39, true);
                WriteLiteral(" type=\"hidden\" name=\"GroupeCompetence\" ");
                EndContext();
                BeginContext(5040, 123, false);
#line 78 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                                                                                 Write(Html.Raw(heureComp != null ? heureComp.GroupeCompetence != null ? "value=\"" + heureComp.GroupeCompetence + "\"" : "" : ""));

#line default
#line hidden
                EndContext();
                BeginContext(5163, 41, true);
                WriteLiteral(" />\r\n                                <div");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 5204, "\"", 5242, 4);
                WriteAttributeValue("", 5209, "btn_", 5209, 4, true);
#line 79 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 5213, Html.Raw(i), 5213, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 5225, "_", 5225, 1, true);
#line 79 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 5226, Competence.Code, 5226, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 5243, "\"", 5313, 3);
                WriteAttributeValue("", 5251, "btn", 5251, 3, true);
                WriteAttributeValue(" ", 5254, "btn-default", 5255, 12, true);
#line 79 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue(" ", 5266, Html.Raw(heureComp == null ? "disabled" : ""), 5267, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 5314, "\"", 5595, 5);
#line 79 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 5322, Html.Raw(heureComp != null ? heureComp.GroupeCompetence != null ? heureComp.GroupeCompetenceNavigation.Couleur != null ? "background-color: " + heureComp.GroupeCompetenceNavigation.Couleur + ";" : "" : "" : ""), 5322, 211, false);

#line default
#line hidden
                WriteAttributeValue("", 5533, ";", 5533, 1, true);
                WriteAttributeValue(" ", 5534, "cursor:", 5535, 8, true);
#line 79 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 5542, Html.Raw(heureComp != null ? "pointer" : "default"), 5542, 52, false);

#line default
#line hidden
                WriteAttributeValue("", 5594, ";", 5594, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 5596, "\"", 6003, 1);
#line 79 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 5606, Html.Raw(heureComp != null ? "var Reset = $('#input_" + i + "_" + Competence.Code + "').val() == $('#selectGroupe').val() ;$('#input_" + i + "_" + Competence.Code + "').val(Reset?'':$('#selectGroupe').val()); $('#btn_" + i + "_" + Competence.Code + "').css('background-color', Reset?'':couleurs[$('#input_" + i + "_" + Competence.Code + "').val()]); $(event.target.parentElement).submit();" : ""), 5606, 397, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6004, 66, true);
                WriteLiteral(">\r\n                                    <input type=\"text\" readonly");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6070, "\"", 6126, 6);
                WriteAttributeValue("", 6078, "form-control", 6078, 12, true);
                WriteAttributeValue(" ", 6090, "th-td-repartition", 6091, 18, true);
                WriteAttributeValue(" ", 6108, "C_", 6109, 3, true);
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 6111, increment, 6111, 10, false);

#line default
#line hidden
                WriteAttributeValue(" ", 6121, "S_", 6122, 3, true);
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 6124, i, 6124, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6127, 14, true);
                WriteLiteral(" maxlength=\"2\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6141, "\"", 6195, 1);
                WriteAttributeValue("", 6149, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                                                                                                               if (heureComp != null) { 

#line default
#line hidden
                    BeginContext(6176, 17, false);
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                                                                                                                                   Write(heureComp.NbHeure);

#line default
#line hidden
                    EndContext();
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                                                                                                                                                                                           }

#line default
#line hidden
                    PopWriter();
                }
                ), 6149, 46, false);
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 6196, "\"", 6340, 6);
                WriteAttributeValue("", 6204, "padding:0;", 6204, 10, true);
                WriteAttributeValue(" ", 6214, "cursor:", 6215, 8, true);
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 6222, Html.Raw(heureComp != null ? "pointer" : "default"), 6222, 52, false);

#line default
#line hidden
                WriteAttributeValue("", 6274, ";", 6274, 1, true);
#line 80 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue(" ", 6275, Html.Raw(heureComp == null ? "background-color: #c5c5c5" : ""), 6276, 63, false);

#line default
#line hidden
                WriteAttributeValue("", 6339, ";", 6339, 1, true);
                EndWriteAttribute();
                BeginContext(6341, 15, true);
                WriteLiteral(" />\r\n</div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6363, 11, true);
            WriteLiteral("\r\n\r\n</td>\r\n");
            EndContext();
#line 86 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                    }

#line default
#line hidden
            BeginContext(6397, 65, true);
            WriteLiteral("                    <td style=\"background-color: #343a40;\"><input");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6462, "\"", 6521, 4);
            WriteAttributeValue("", 6470, "form-control", 6470, 12, true);
            WriteAttributeValue(" ", 6482, "th-td-repartition-tot", 6483, 22, true);
            WriteAttributeValue(" ", 6504, "Tot_C_", 6505, 7, true);
#line 87 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 6511, increment, 6511, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6522, 179, true);
            WriteLiteral(" style=\"background-color: #1d1f21; font-weight: bold; padding: 0; text-align: center; border: 0;color: white; margin: auto; width: 28px;\" readonly /></td>\r\n                </tr>\r\n");
            EndContext();
#line 89 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                increment++;
            }

#line default
#line hidden
            BeginContext(6746, 151, true);
            WriteLiteral("            <tr style=\"background-color:#343a40; color:white;\">\r\n                <td style=\"text-align:left!important; font-weight: bold;\">Total</td>\r\n");
            EndContext();
#line 93 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                 for (int i = 1; i <= 6; i++)
                {

#line default
#line hidden
            BeginContext(6963, 170, true);
            WriteLiteral("                    <td><input style=\"background-color: #1d1f21; font-weight: bold; padding: 0; text-align: center; border: 0;color: white; padding:0; text-align:center;\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 7133, "\"", 7168, 4);
            WriteAttributeValue("", 7141, "form-control", 7141, 12, true);
            WriteAttributeValue(" ", 7153, "Tot_S", 7154, 6, true);
            WriteAttributeValue(" ", 7159, "Tot_S_", 7160, 7, true);
#line 95 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
WriteAttributeValue("", 7166, i, 7166, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7169, 19, true);
            WriteLiteral(" readonly /></td>\r\n");
            EndContext();
#line 96 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                }

#line default
#line hidden
            BeginContext(7207, 330, true);
            WriteLiteral(@"                <td><input class=""form-control Tot_SC"" style=""background-color: #1d1f21; font-weight: bold; padding: 0; text-align: center; border: 0;color: white; margin: auto; width: 28px;"" readonly /></td>
            </tr>
        </tbody>
    </table>
</div>

<script>
        $(function () {
            updateTable(");
            EndContext();
            BeginContext(7538, 9, false);
#line 105 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\GroupeCompetence_Profil.cshtml"
                   Write(increment);

#line default
#line hidden
            EndContext();
            BeginContext(7547, 34, true);
            WriteLiteral("-1);\r\n        });\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
