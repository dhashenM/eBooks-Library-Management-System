#pragma checksum "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02336491d51d8124a9a79a3cc66e10a1f963d8bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
#line 1 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\_ViewImports.cshtml"
using eBooks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\_ViewImports.cshtml"
using eBooks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02336491d51d8124a9a79a3cc66e10a1f963d8bd", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd9f27e4a66123fb88feb7afaa1b1ad69ae2ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of all users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6 offset-3\">\n        <p>\n            <h4>List of all users</h4>\n        </p>\n\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
#nullable restore
#line 16 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 17 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 18 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th></th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 24 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 28 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 31 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 34 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1219, "\"", 1294, 2);
#nullable restore
#line 37 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
WriteAttributeValue("", 1229, "window.location.href='" + Url.Action("Edit","Account") + "'", 1229, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1293, ";", 1293, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">\n                            <i class=\"bi bi-pencil-square\"></i> Edit\n                        </a>\n                    </td>\n                    <td class=\"align-middle\">\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1525, "\"", 1606, 2);
#nullable restore
#line 42 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
WriteAttributeValue("", 1535, "window.location.href='" + Url.Action("DeleteUser","Account") + "'", 1535, 70, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1605, ";", 1605, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-white\">\n                            <i class=\"bi bi-trash\"></i> Delete\n                        </a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 47 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>\n\n<div style=\"position: fixed; right: 25px; bottom: 25px;\" class=\"text-white\">\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1941, "\"", 2020, 2);
#nullable restore
#line 54 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Account\Users.cshtml"
WriteAttributeValue("", 1951, "window.location.href='" + Url.Action("Register","Account") + "'", 1951, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2019, ";", 2019, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\n        <i class=\"bi bi-plus-circle\"></i> Add New\n    </a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
