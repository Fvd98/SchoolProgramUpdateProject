#pragma checksum "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63310d45697c904264ca3cfd6efa95341c828c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NiveauTaxonomique), @"mvc.1.0.view", @"/Views/Admin/NiveauTaxonomique.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/NiveauTaxonomique.cshtml", typeof(AspNetCore.Views_Admin_NiveauTaxonomique))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63310d45697c904264ca3cfd6efa95341c828c73", @"/Views/Admin/NiveauTaxonomique.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab37d2a19db97e1812d2a0e685ff62998308c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NiveauTaxonomique : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutilsActualisation.AppData.ModeleTaxonomique>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 186, true);
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n    <h4 class=\"modal-title\">Liste des niveaux taxonomiques du modèle <strong>");
            EndContext();
            BeginContext(241, 9, false);
#line 5 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                                                                        Write(Model.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(250, 255, true);
            WriteLiteral("</strong></h4>\r\n</div>\r\n\r\n<div class=\"modal-body\">\r\n\r\n    <a style=\"margin-bottom:7px; margin-right:5%; float:right\" class=\"btn btn-success\" onclick=\"AjaxFill(\'/Admin/NiveauTaxonomique_Create\', \'#ModalContainer\', true)\">Créer un niveau taxonomique</a>\r\n\r\n");
            EndContext();
#line 12 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
     if (Model.NiveauTaxonomique.Count() != 0)
    {

#line default
#line hidden
            BeginContext(560, 178, true);
            WriteLiteral("        <table class=\"tableD\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(739, 67, false);
#line 20 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                   Write(Html.DisplayNameFor(model => model.NiveauTaxonomique.First().Terme));

#line default
#line hidden
            EndContext();
            BeginContext(806, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 26 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                 foreach (var item in Model.NiveauTaxonomique)
                {

#line default
#line hidden
            BeginContext(1015, 400, true);
            WriteLiteral(@"                    <tr>
                        <td style=""width:40px; padding: 5px 5px;"">
                            <a class=""btn btn-default glyphicon glyphicon-arrow-up"" style=""padding:6px 8px 6px 6px""></a><a class=""btn btn-default glyphicon glyphicon-arrow-down"" style=""padding:6px 8px 6px 6px;""></a>
                        </td>
                        <td>
                            ");
            EndContext();
            BeginContext(1416, 40, false);
#line 33 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Terme));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 180, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"padding-right:0; width: 124px;\">\r\n                            <span style=\"width:109px;\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1636, "\"", 1727, 5);
            WriteAttributeValue("", 1646, "AjaxFill(\'/Admin/NiveauTaxonomique_Update?id=", 1646, 45, true);
#line 36 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
WriteAttributeValue("", 1691, item.Id, 1691, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1699, "\',", 1699, 2, true);
            WriteAttributeValue(" ", 1701, "\'#ModalContainer\',", 1702, 19, true);
            WriteAttributeValue(" ", 1720, "true);", 1721, 7, true);
            EndWriteAttribute();
            BeginContext(1728, 236, true);
            WriteLiteral("><span style=\"margin-right:7px;\" class=\"glyphicon glyphicon-pencil\"></span>Modifier</span>\r\n                            <a style=\"width:109px; margin-top: 3.5px;\" class=\"btn btn-danger\" data-ajax-url=\"/Admin/NiveauTaxonomique_Delete?id=");
            EndContext();
            BeginContext(1965, 7, false);
#line 37 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                                                                                                                                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1972, 100, true);
            WriteLiteral("\" data-ajax=\"true\" data-ajax-method=\"POST\" data-ajax-success=\"AjaxFill(\'/Admin/NiveauTaxonomique?id=");
            EndContext();
            BeginContext(2073, 13, false);
#line 37 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                                                                                                                                                                                                                                                       Write(ViewBag.ModID);

#line default
#line hidden
            EndContext();
            BeginContext(2086, 230, true);
            WriteLiteral("\', \'#ModalContainer\', false);\" data-ajax-failure=\"Alert(\'error\', xhr.responseText)\"><span style=\"margin-right:7px;\" class=\"glyphicon glyphicon-trash\"></span>Supprimer</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 40 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
                }

#line default
#line hidden
            BeginContext(2335, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 43 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2399, 120, true);
            WriteLiteral("        <p style=\"font-weight:bold; font-size:20px; text-align:center;\">Aucun niveau pour ce modèle taxonomique...</p>\r\n");
            EndContext();
#line 47 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\NiveauTaxonomique.cshtml"
    }

#line default
#line hidden
            BeginContext(2526, 14, true);
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutilsActualisation.AppData.ModeleTaxonomique> Html { get; private set; }
    }
}
#pragma warning restore 1591
