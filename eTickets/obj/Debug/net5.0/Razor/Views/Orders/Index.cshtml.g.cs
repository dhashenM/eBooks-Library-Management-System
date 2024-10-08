#pragma checksum "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a78141b72fb3f93f3fd87a67acd7e335a16877a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a78141b72fb3f93f3fd87a67acd7e335a16877a1", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd9f27e4a66123fb88feb7afaa1b1ad69ae2ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
   
    ViewData["Title"] = "All orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <p>
            <h4>List of all your orders</h4>
        </p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Items</th>
                    <th>Total</th>
");
#nullable restore
#line 19 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>User</th>\n");
#nullable restore
#line 22 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th></th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 28 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">");
#nullable restore
#line 31 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"align-middle\">\n                        <ul style=\"list-style-type:none\">\n");
#nullable restore
#line 34 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                             foreach (var item in order.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\n                                    <div class=\"alert alert-info\" role=\"alert\">\n                                        <span class=\"badge bg-success\">");
#nullable restore
#line 38 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                                                                  Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 38 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                                                                                       Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 38 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                                                                                                                    Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </li>\n");
#nullable restore
#line 41 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 45 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                   Write(order.OrderItems.Select(b => b.Book.Price * b.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 47 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-middle\"> ");
#nullable restore
#line 49 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                                             Write(order.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n");
            WriteLiteral("                        <td class=\"align-middle\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a78141b72fb3f93f3fd87a67acd7e335a16877a19697", async() => {
                WriteLiteral("\n                                <i class=\"bi bi-pencil-square\"></i> Edit\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                        <td class=\"align-middle\">\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2157, "\"", 2238, 2);
#nullable restore
#line 57 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
WriteAttributeValue("", 2167, "window.location.href='" + Url.Action("DeleteOrder","Orders") + "'", 2167, 70, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2237, ";", 2237, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-white\">\n                                <i class=\"bi bi-trash\"></i> Delete\n                            </a>\n                        </td>\n");
#nullable restore
#line 61 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 63 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n</div>\n\n<div style=\"position: fixed; right: 25px; bottom: 25px;\" class=\"text-white\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a78141b72fb3f93f3fd87a67acd7e335a16877a112665", async() => {
                WriteLiteral("\n        <i class=\"bi bi-plus-circle\"></i> Add New\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
