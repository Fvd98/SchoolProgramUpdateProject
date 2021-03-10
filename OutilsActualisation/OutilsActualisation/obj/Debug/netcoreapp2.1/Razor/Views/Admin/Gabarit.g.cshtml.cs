#pragma checksum "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3489afcfc7ba0b540302c64d77fafe966f5289b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Gabarit), @"mvc.1.0.view", @"/Views/Admin/Gabarit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Gabarit.cshtml", typeof(AspNetCore.Views_Admin_Gabarit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3489afcfc7ba0b540302c64d77fafe966f5289b9", @"/Views/Admin/Gabarit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ab37d2a19db97e1812d2a0e685ff62998308c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Gabarit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutilsActualisation.Models.GabaritsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    IEnumerable<OutilsActualisation.AppData.Gabarit> listeGabarits;
    #region Check
    string Check = "ok";
    string NotCheck = "remove";
    string Red = "red";
    string Green = "green";
    #endregion Check

#line default
#line hidden
            BeginContext(332, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
 foreach (var Type in Model.typeGabarit)
{
    listeGabarits = Model.gabarits.Where(G => G.TypeGabarit == Type.Id);


#line default
#line hidden
            BeginContext(455, 60, true);
            WriteLiteral("    <h2 style=\"margin-left:5%;\">Liste des gabarits de type \"");
            EndContext();
            BeginContext(516, 8, false);
#line 18 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                       Write(Type.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(524, 81, true);
            WriteLiteral("\"<span style=\"float:right; margin-right: calc(5% + 3px);\" class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 605, "\"", 691, 5);
            WriteAttributeValue("", 615, "AjaxFill(\'/Admin/Gabarit_Create?TypeID=", 615, 39, true);
#line 18 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
WriteAttributeValue("", 654, Type.Id, 654, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 662, "\',", 662, 2, true);
            WriteAttributeValue(" ", 664, "\'#ModalContainer\',", 665, 19, true);
            WriteAttributeValue(" ", 683, "false);", 684, 8, true);
            EndWriteAttribute();
            BeginContext(692, 39, true);
            WriteLiteral(">Créer un nouveau gabarit</span></h2>\r\n");
            EndContext();
#line 20 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
     if (listeGabarits.ToList().Count == 0)
    {

#line default
#line hidden
            BeginContext(785, 150, true);
            WriteLiteral("        <br />\r\n        <p style=\"font-weight:bold; font-size:20px; text-align:center;\">Aucun gabarit pour ce type de gabarit...</p>\r\n        <br />\r\n");
            EndContext();
#line 25 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(959, 125, true);
            WriteLiteral("        <table class=\"tableD\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1085, 56, false);
#line 32 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                   Write(Html.DisplayNameFor(model => model.gabarits.First().Nom));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1221, 65, false);
#line 35 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                   Write(Html.DisplayNameFor(model => model.gabarits.First().DateCreation));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1366, 62, false);
#line 38 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                   Write(Html.DisplayNameFor(model => model.gabarits.First().IsDefault));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 44 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                 foreach (var item in listeGabarits)
                {

#line default
#line hidden
            BeginContext(1627, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1712, 38, false);
#line 48 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1842, 47, false);
#line 51 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateCreation));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 96, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1985, "\"", 2067, 4);
            WriteAttributeValue("", 1993, "color:", 1993, 6, true);
            WriteAttributeValue("", 1999, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                if (item.IsDefault.Value) { 

#line default
#line hidden
                BeginContext(2029, 5, false);
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                       Write(Green);

#line default
#line hidden
                EndContext();
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                   } else { 

#line default
#line hidden
                BeginContext(2045, 3, false);
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                       Write(Red);

#line default
#line hidden
                EndContext();
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                 }

#line default
#line hidden
                PopWriter();
            }
            ), 1999, 51, false);
            WriteAttributeValue("", 2050, ";", 2050, 1, true);
            WriteAttributeValue(" ", 2051, "font-size:15px;", 2052, 16, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2068, "\"", 2152, 3);
            WriteAttributeValue("", 2076, "glyphicon", 2076, 9, true);
            WriteAttributeValue(" ", 2085, "glyphicon-", 2086, 11, true);
            WriteAttributeValue("", 2096, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                                                                 if (item.IsDefault.Value) { 

#line default
#line hidden
                BeginContext(2126, 5, false);
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                                                                                        Write(Check);

#line default
#line hidden
                EndContext();
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                                                                                                    } else { 

#line default
#line hidden
                BeginContext(2142, 8, false);
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                                                                                                        Write(NotCheck);

#line default
#line hidden
                EndContext();
#line 54 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                                                                                                                       }

#line default
#line hidden
                PopWriter();
            }
            ), 2096, 56, false);
            EndWriteAttribute();
            BeginContext(2153, 183, true);
            WriteLiteral("></span>\r\n                        </td>\r\n                        <td style=\"padding-left:0; padding-right:0; width: 346px;\">\r\n                            <span class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2336, "\"", 2415, 5);
            WriteAttributeValue("", 2346, "AjaxFill(\'/Admin/PointGabarit?id=", 2346, 33, true);
#line 57 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
WriteAttributeValue("", 2379, item.Id, 2379, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2387, "\',", 2387, 2, true);
            WriteAttributeValue(" ", 2389, "\'#ModalContainer\',", 2390, 19, true);
            WriteAttributeValue(" ", 2408, "true);", 2409, 7, true);
            EndWriteAttribute();
            BeginContext(2416, 154, true);
            WriteLiteral("><span style=\"margin-right:7px;\" class=\"glyphicon glyphicon-eye-open\"></span>Voir points</span>\r\n                            <span class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2570, "\"", 2651, 5);
            WriteAttributeValue("", 2580, "AjaxFill(\'/Admin/Gabarit_Update?id=", 2580, 35, true);
#line 58 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
WriteAttributeValue("", 2615, item.Id, 2615, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2623, "\',", 2623, 2, true);
            WriteAttributeValue(" ", 2625, "\'#ModalContainer\',", 2626, 19, true);
            WriteAttributeValue(" ", 2644, "true);", 2645, 7, true);
            EndWriteAttribute();
            BeginContext(2652, 196, true);
            WriteLiteral("><span style=\"margin-right:7px;\" class=\"glyphicon glyphicon-pencil\"></span>Modifier</span>\r\n                            <a style=\" \" class=\"btn btn-danger\" data-ajax-url=\"/Admin/Gabarit_Delete?id=");
            EndContext();
            BeginContext(2849, 7, false);
#line 59 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2856, 281, true);
            WriteLiteral(@""" data-ajax=""true"" data-ajax-method=""POST"" data-ajax-success=""location.reload();"" data-ajax-failure=""Alert('error', xhr.responseText)""><span style=""margin-right:7px;"" class=""glyphicon glyphicon-trash""></span>Supprimer</a>
                        </td>
                    </tr>
");
            EndContext();
#line 62 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
                }

#line default
#line hidden
            BeginContext(3156, 56, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <br />\r\n");
            EndContext();
#line 66 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
    }

#line default
#line hidden
#line 66 "F:\ProjetFinal - V0.1.4\OutilsActualisation\OutilsActualisation\Views\Admin\Gabarit.cshtml"
     
}

#line default
#line hidden
            BeginContext(3222, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutilsActualisation.Models.GabaritsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591