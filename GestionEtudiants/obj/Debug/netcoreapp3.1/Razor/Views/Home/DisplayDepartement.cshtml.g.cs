#pragma checksum "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\Home\DisplayDepartement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1b5c8eea91bcac67566c8489af206f148e2e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayDepartement), @"mvc.1.0.view", @"/Views/Home/DisplayDepartement.cshtml")]
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
#nullable restore
#line 1 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1b5c8eea91bcac67566c8489af206f148e2e7c", @"/Views/Home/DisplayDepartement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayDepartement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid py-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card mb-4"">
                <div class=""card-header pb-0"">
                    <h6>Departements</h6>
                </div>
                <div class=""card-body"">
                    <table class=""table"" id=""TableDeps"">
                        <thead>
                            <tr>
                                <th>
                                    ID
                                </th>
                                <th>
                                    Nom
                                </th>
                                <th>
                                    Action
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\Home\DisplayDepartement.cshtml"
                             foreach (var n in ViewBag.dep)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\Home\DisplayDepartement.cshtml"
                   Write(n.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\Home\DisplayDepartement.cshtml"
                   Write(n.nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a type=\"button\" rel=\"tooltip\" class=\"btn btn-icon btn-sm btn-simple bg-transparent\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 1435, "\"", 1443, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1507, 1);
#nullable restore
#line 39 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\Home\DisplayDepartement.cshtml"
WriteAttributeValue("", 1451, Url.Action("DeleteDepartement","Home",new {id = n.id }), 1451, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
                                <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                                <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"" />
                            </svg>
                        </a>
                    </td>
                </tr>
");
#nullable restore
#line 47 "C:\Users\17pixelz\Desktop\AdminApp\GestionEtudiants\Views\Home\DisplayDepartement.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>$(document).ready(function () {\r\n        $(\'#TableDeps\').DataTable();\r\n    });</script>");
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
