#pragma checksum "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7754de7a06b56d682ceb91ce5de5ca5e195dedce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competence_RepartitionHeure_Instance), @"mvc.1.0.view", @"/Views/Competence/RepartitionHeure_Instance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Competence/RepartitionHeure_Instance.cshtml", typeof(AspNetCore.Views_Competence_RepartitionHeure_Instance))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7754de7a06b56d682ceb91ce5de5ca5e195dedce", @"/Views/Competence/RepartitionHeure_Instance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab37d2a19db97e1812d2a0e685ff62998308c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Competence_RepartitionHeure_Instance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutilsActualisation.AppData.InstanceHeureCompetence>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Competence", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RepartitionHeure", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("Alert(\'error\',\'L\\\'enregistrement a échoué.\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
   
    int increment = 1;

#line default
#line hidden
            BeginContext(92, 366, true);
            WriteLiteral(@"<style>
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

");
            EndContext();
#line 25 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
 if (ViewBag.HeureMin == null || ViewBag.HeureMax == null)
{

#line default
#line hidden
            BeginContext(521, 232, true);
            WriteLiteral("    <br/>\r\n    <div style=\"font-weight:bold; text-align:center;\">Cette étape requiert que vous ayez entré le nombre d\'heures total minimum et maximum de la formation spécifique à l\'étape Devis - Unités et heures.</div>\r\n    <br />\r\n");
            EndContext();
#line 30 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(765, 123, true);
            WriteLiteral("    <div>Le nombre d\'heures total de la formation spécifique doit être entre <span style=\"font-weight:bold;\" id=\"HeureMin\">");
            EndContext();
            BeginContext(889, 16, false);
#line 33 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                      Write(ViewBag.HeureMin);

#line default
#line hidden
            EndContext();
            BeginContext(905, 57, true);
            WriteLiteral("</span> et <span id=\"HeureMax\" style=\"font-weight:bold;\">");
            EndContext();
            BeginContext(963, 16, false);
#line 33 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                Write(ViewBag.HeureMax);

#line default
#line hidden
            EndContext();
            BeginContext(979, 889, true);
            WriteLiteral(@"</span></div>
    <br />
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
#line 49 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
             foreach (var Competence in Model.ProfilFormationNavigation.CompetenceProfilFormation.ToList())
            {

#line default
#line hidden
            BeginContext(1992, 81, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:left!important;\">");
            EndContext();
            BeginContext(2074, 36, false);
#line 52 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                      Write(Competence.CompetenceNavigation.Code);

#line default
#line hidden
            EndContext();
            BeginContext(2110, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2114, 38, false);
#line 52 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                              Write(Competence.CompetenceNavigation.Enonce);

#line default
#line hidden
            EndContext();
            BeginContext(2152, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 53 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                     for (int i = 1; i <= 6; i++)
                    {
                        OutilsActualisation.AppData.HeureComp heureComp = Model.HeureComp.Where(HC => HC.Competence == Competence.Competence && HC.NoSession == i).FirstOrDefault();

#line default
#line hidden
            BeginContext(2415, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2473, 1292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe295fb9e0e46d397b7f9e89c57c825", async() => {
                BeginContext(2885, 40, true);
                WriteLiteral("\r\n                                <input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2925, "\"", 2962, 4);
                WriteAttributeValue("", 2930, "nouveau_", 2930, 8, true);
#line 58 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 2938, Html.Raw(i), 2938, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2950, "_", 2950, 1, true);
#line 58 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 2951, Competence, 2951, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2963, 29, true);
                WriteLiteral(" type=\"hidden\" name=\"nouveau\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2992, "\"", 3026, 1);
#line 58 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3000, Html.Raw(heureComp==null), 3000, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3027, 74, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"NoSession\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3101, "\"", 3111, 1);
#line 59 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3109, i, 3109, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3112, 75, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"Competence\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3187, "\"", 3217, 1);
#line 60 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3195, Competence.Competence, 3195, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3218, 88, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"InstanceHeureCompetence\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3306, "\"", 3323, 1);
#line 61 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3314, Model.Id, 3314, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3324, 70, true);
                WriteLiteral(" />\r\n                                <input type=\"text\" name=\"NbHeure\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3394, "\"", 3429, 4);
                WriteAttributeValue("", 3399, "input_", 3399, 6, true);
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3405, Html.Raw(i), 3405, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 3417, "_", 3417, 1, true);
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3418, Competence, 3418, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 3430, "\"", 3486, 6);
                WriteAttributeValue("", 3438, "form-control", 3438, 12, true);
                WriteAttributeValue(" ", 3450, "th-td-repartition", 3451, 18, true);
                WriteAttributeValue(" ", 3468, "C_", 3469, 3, true);
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3471, increment, 3471, 10, false);

#line default
#line hidden
                WriteAttributeValue(" ", 3481, "S_", 3482, 3, true);
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3484, i, 3484, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3487, 164, true);
                WriteLiteral(" maxlength=\"2\" onfocus=\"Window.OldValue = $(event.target).val();\" onblur=\"if (Window.OldValue != $(event.target).val()) { $(event.target.parentElement).submit(); }\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3651, "\"", 3705, 1);
                WriteAttributeValue("", 3659, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                                                                                                                                           if (heureComp != null) { 

#line default
#line hidden
                    BeginContext(3686, 17, false);
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                                                                                                                                                               Write(heureComp.NbHeure);

#line default
#line hidden
                    EndContext();
#line 62 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                       }

#line default
#line hidden
                    PopWriter();
                }
                ), 3659, 46, false);
                EndWriteAttribute();
                BeginContext(3706, 52, true);
                WriteLiteral(" style=\"padding:0;\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            WriteLiteral("$(\'#nouveau_");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                               Write(Html.Raw(i));

#line default
#line hidden
            WriteLiteral("_");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                            Write(Competence);

#line default
#line hidden
            WriteLiteral("\').val($(\'#input_");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                        Write(Html.Raw(i));

#line default
#line hidden
            WriteLiteral("_");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                     Write(Competence);

#line default
#line hidden
            WriteLiteral("\').val() != \'\'); updateTable(");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                                                             Write(Model.ProfilFormationNavigation.CompetenceProfilFormation.ToList().Count());

#line default
#line hidden
            WriteLiteral(", ");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                                                                                                                                          Write(ViewBag.HeureMin);

#line default
#line hidden
            WriteLiteral(", ");
#line 57 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                                                                                                                                                                                                                                                                                                                             Write(ViewBag.HeureMax);

#line default
#line hidden
            WriteLiteral(");");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-success", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3765, 35, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n");
            EndContext();
#line 66 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                    }

#line default
#line hidden
            BeginContext(3823, 65, true);
            WriteLiteral("                    <td style=\"background-color: #343a40;\"><input");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3888, "\"", 3947, 4);
            WriteAttributeValue("", 3896, "form-control", 3896, 12, true);
            WriteAttributeValue(" ", 3908, "th-td-repartition-tot", 3909, 22, true);
            WriteAttributeValue(" ", 3930, "Tot_C_", 3931, 7, true);
#line 67 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 3937, increment, 3937, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3948, 179, true);
            WriteLiteral(" style=\"background-color: #1d1f21; font-weight: bold; padding: 0; text-align: center; border: 0;color: white; margin: auto; width: 28px;\" readonly /></td>\r\n                </tr>\r\n");
            EndContext();
#line 69 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                increment++;
            }

#line default
#line hidden
            BeginContext(4172, 151, true);
            WriteLiteral("            <tr style=\"background-color:#343a40; color:white;\">\r\n                <td style=\"text-align:left!important; font-weight: bold;\">Total</td>\r\n");
            EndContext();
#line 73 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                 for (int i = 1; i <= 6; i++)
                {

#line default
#line hidden
            BeginContext(4389, 170, true);
            WriteLiteral("                    <td><input style=\"background-color: #1d1f21; font-weight: bold; padding: 0; text-align: center; border: 0;color: white; padding:0; text-align:center;\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4559, "\"", 4594, 4);
            WriteAttributeValue("", 4567, "form-control", 4567, 12, true);
            WriteAttributeValue(" ", 4579, "Tot_S", 4580, 6, true);
            WriteAttributeValue(" ", 4585, "Tot_S_", 4586, 7, true);
#line 75 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
WriteAttributeValue("", 4592, i, 4592, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4595, 19, true);
            WriteLiteral(" readonly /></td>\r\n");
            EndContext();
#line 76 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                }

#line default
#line hidden
            BeginContext(4633, 592, true);
            WriteLiteral(@"                <td><input class=""form-control Tot_SC"" style=""background-color: #1d1f21; font-weight: bold; padding: 0; text-align: center; border: 0;color: white; margin: auto; width: 28px;"" readonly /></td>
            </tr>
            <tr>
                <td colspan=""8"" style=""text-align:right;background-color: #1d1f21; font-weight: bold;color:white"">
                    Total d'heures actuel = <span id=""totalHebdo""></span> heures X 15 semaines = <span id=""reelTotal""></span> heures totales du programme
                </td>
            </tr>
        </tbody>
    </table>
");
            EndContext();
            BeginContext(5227, 63, true);
            WriteLiteral("    <script>\r\n        $(function () {\r\n            updateTable(");
            EndContext();
            BeginContext(5291, 9, false);
#line 89 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                   Write(increment);

#line default
#line hidden
            EndContext();
            BeginContext(5300, 4, true);
            WriteLiteral("-1, ");
            EndContext();
            BeginContext(5305, 16, false);
#line 89 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                 Write(ViewBag.HeureMin);

#line default
#line hidden
            EndContext();
            BeginContext(5321, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(5324, 16, false);
#line 89 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
                                                    Write(ViewBag.HeureMax);

#line default
#line hidden
            EndContext();
            BeginContext(5340, 42, true);
            WriteLiteral(");\r\n        });\r\n        \r\n    </script>\r\n");
            EndContext();
#line 93 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Competence\RepartitionHeure_Instance.cshtml"
}

#line default
#line hidden
            BeginContext(5385, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutilsActualisation.AppData.InstanceHeureCompetence> Html { get; private set; }
    }
}
#pragma warning restore 1591
