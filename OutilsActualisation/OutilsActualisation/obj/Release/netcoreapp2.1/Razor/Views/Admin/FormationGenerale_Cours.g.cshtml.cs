#pragma checksum "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83834b82e12b45fd698087a1a3b92274f6aaaa20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_FormationGenerale_Cours), @"mvc.1.0.view", @"/Views/Admin/FormationGenerale_Cours.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/FormationGenerale_Cours.cshtml", typeof(AspNetCore.Views_Admin_FormationGenerale_Cours))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83834b82e12b45fd698087a1a3b92274f6aaaa20", @"/Views/Admin/FormationGenerale_Cours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab37d2a19db97e1812d2a0e685ff62998308c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_FormationGenerale_Cours : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OutilsActualisation.AppData.Cours>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
  
    int Increment = 0;

#line default
#line hidden
            BeginContext(86, 247, true);
            WriteLiteral("\r\n<h3 style=\"margin-top:10px;\">Liste des cours de la formation générale<span style=\"float:right;\" class=\"btn btn-success\" onclick=\"AjaxFill(\'/Admin/FormationGenerale_Cours_Create\', \'#ModalContainer\', false);\">Créer un cours</span></h3>\r\n<br />\r\n\r\n");
            EndContext();
#line 9 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
 if (Model.Count() != 0)
{
    

#line default
#line hidden
#line 11 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
     foreach (var Cours in Model)
    {

#line default
#line hidden
            BeginContext(404, 126, true);
            WriteLiteral("        <span class=\"btn btn-dark btn-success\" style=\"width:100%; padding:6px;\" data-toggle=\"collapse\" data-target=\"#collapse_");
            EndContext();
            BeginContext(531, 9, false);
#line 13 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                                                                                                                         Write(Increment);

#line default
#line hidden
            EndContext();
            BeginContext(540, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 541, "\"", 576, 2);
            WriteAttributeValue("", 557, "collapse_", 557, 9, true);
#line 13 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
WriteAttributeValue("", 566, Increment, 566, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(577, 156, true);
            WriteLiteral(">\r\n            <span class=\"badge badge-light\" style=\"color:black; border-radius:3px; float:left; vertical-align:central;margin-top:2px; margin-right:6px;\">");
            EndContext();
            BeginContext(734, 11, false);
#line 14 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                                                                                                                                                    Write(Cours.Sigle);

#line default
#line hidden
            EndContext();
            BeginContext(745, 21, true);
            WriteLiteral("</span>\r\n            ");
            EndContext();
            BeginContext(767, 11, false);
#line 15 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
       Write(Cours.Titre);

#line default
#line hidden
            EndContext();
            BeginContext(778, 100, true);
            WriteLiteral("\r\n            <a title=\"Supprimer le cours\" data-ajax-url=\"/Admin/FormationGenerale_Cours_Delete?id=");
            EndContext();
            BeginContext(879, 8, false);
#line 16 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                                                                                             Write(Cours.Id);

#line default
#line hidden
            EndContext();
            BeginContext(887, 340, true);
            WriteLiteral(@""" data-ajax=""true"" data-ajax-method=""POST"" data-ajax-success=""AjaxFill('/Admin/FormationGenerale_Cours', '#menu', false)"" data-ajax-failure=""Alert('error', xhr.responseText)"" style=""float:right; font-size:10px; padding:2px 5px; float:right;"" class=""btn btn-danger glyphicon glyphicon-trash""></a>
            <span title=""Modifier le cours""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1227, "\"", 1350, 5);
            WriteAttributeValue("", 1237, "AjaxFill(\'/Admin/FormationGenerale_Cours_Update?id=", 1237, 51, true);
#line 17 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
WriteAttributeValue("", 1288, Cours.Id, 1288, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1297, "\',", 1297, 2, true);
            WriteAttributeValue(" ", 1299, "\'#ModalContainer\',", 1300, 19, true);
            WriteAttributeValue(" ", 1318, "false);event.stopPropagation();", 1319, 32, true);
            EndWriteAttribute();
            BeginContext(1351, 210, true);
            WriteLiteral(" style=\"float:right; font-size:10px; padding:2px 5px; float:right; margin-right:6px;\" class=\"btn btn-warning glyphicon glyphicon-pencil\"></span>\r\n            <span title=\"Modifier les compétences pour le cours\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1561, "\"", 1688, 5);
            WriteAttributeValue("", 1571, "AjaxFill(\'/Admin/FormationGenerale_Cours_Competence?id=", 1571, 55, true);
#line 18 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
WriteAttributeValue("", 1626, Cours.Id, 1626, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1635, "\',", 1635, 2, true);
            WriteAttributeValue(" ", 1637, "\'#ModalContainer\',", 1638, 19, true);
            WriteAttributeValue(" ", 1656, "false);event.stopPropagation();", 1657, 32, true);
            EndWriteAttribute();
            BeginContext(1689, 190, true);
            WriteLiteral(" style=\"float:right; font-size:10px; padding:2px 5px; float:right; margin-right:6px;\" class=\"btn btn-primary glyphicon glyphicon-list\"></span>\r\n        </span>\r\n        <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1879, "\"", 1903, 2);
            WriteAttributeValue("", 1884, "collapse_", 1884, 9, true);
#line 20 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
WriteAttributeValue("", 1893, Increment, 1893, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1904, 143, true);
            WriteLiteral(">\r\n            <div style=\"background-color:rgba(200, 200, 200, 0.54); margin:2px; margin-top:0; padding: 10px; border-radius: 0 0 4px 4px;\">\r\n");
            EndContext();
#line 22 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                 if (Cours.CoursCompetence.Count() != 0)
                {
                    

#line default
#line hidden
#line 24 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                     foreach (var CoursCompetence in Cours.CoursCompetence)
                    {

#line default
#line hidden
            BeginContext(2224, 258, true);
            WriteLiteral(@"                        <div style=""display:flex"">
                            <span class=""badge badge-light"" style=""height:18px;background-color:#343a40;color:white; border-radius:3px; float:left; vertical-align:central;margin-top:2px; margin-right:6px;"">");
            EndContext();
            BeginContext(2483, 41, false);
#line 27 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                                                                                                                                                                                                         Write(CoursCompetence.CompetenceNavigation.Code);

#line default
#line hidden
            EndContext();
            BeginContext(2524, 117, true);
            WriteLiteral("</span>\r\n                            <label style=\"text-align:left; flex-grow: 1;\">\r\n                                ");
            EndContext();
            BeginContext(2642, 43, false);
#line 29 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                           Write(CoursCompetence.CompetenceNavigation.Enonce);

#line default
#line hidden
            EndContext();
            BeginContext(2685, 107, true);
            WriteLiteral("\r\n                                <a data-ajax-url=\"/Admin/FormationGenerale_Cours_Competence?idCompetence=");
            EndContext();
            BeginContext(2793, 26, false);
#line 30 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                                                                                                    Write(CoursCompetence.Competence);

#line default
#line hidden
            EndContext();
            BeginContext(2819, 9, true);
            WriteLiteral("&idCours=");
            EndContext();
            BeginContext(2829, 21, false);
#line 30 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                                                                                                                                        Write(CoursCompetence.Cours);

#line default
#line hidden
            EndContext();
            BeginContext(2850, 383, true);
            WriteLiteral(@"&Ajouter=false"" data-ajax=""true"" data-ajax-method=""POST"" data-ajax-success=""AjaxFill('/Admin/FormationGenerale_Cours', '#menu', false);"" data-ajax-failure=""Alert('error', xhr.responseText)"" style=""float:right; font-size:10px; padding:2px 5px; float:right;"" class=""btn btn-danger glyphicon glyphicon-remove""></a>
                            </label>
                        </div>
");
            EndContext();
#line 33 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                    }

#line default
#line hidden
#line 33 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                     
                }
                else
                {

#line default
#line hidden
            BeginContext(3316, 180, true);
            WriteLiteral("                    <br />\r\n                    <p style=\"font-weight:bold; font-size:20px; text-align:center;\">Aucune compétence pour ce cours...</p>\r\n                    <br />\r\n");
            EndContext();
#line 40 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
                }    

#line default
#line hidden
            BeginContext(3519, 89, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div style=\"width:100%; height:7px;\"></div>\r\n");
            EndContext();
#line 44 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
        Increment++;
    }

#line default
#line hidden
#line 45 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(3649, 142, true);
            WriteLiteral("    <br />\r\n    <p style=\"font-weight:bold; font-size:20px; text-align:center;\">Aucun cours pour cette formation générale...</p>\r\n    <br />\r\n");
            EndContext();
#line 52 "K:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\FormationGenerale_Cours.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OutilsActualisation.AppData.Cours>> Html { get; private set; }
    }
}
#pragma warning restore 1591