#pragma checksum "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e6ba0203988f19e2f9426146b9b83f4aea92437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Index), @"mvc.1.0.view", @"/Views/Publishers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e6ba0203988f19e2f9426146b9b83f4aea92437", @"/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd9f27e4a66123fb88feb7afaa1b1ad69ae2ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
  
    ViewData["Title"] = "List of Publishers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-8 offset-md-2\">\n\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
#nullable restore
#line 14 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 15 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 16 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 17 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>Actions</th>\n");
#nullable restore
#line 20 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 24 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">\n                        <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1042, "\"", 1058, 1);
#nullable restore
#line 28 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 1048, item.Logo, 1048, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1059, "\"", 1075, 1);
#nullable restore
#line 28 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 1065, item.Name, 1065, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 31 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 34 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 36 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-middle\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6ba0203988f19e2f9426146b9b83f4aea924379698", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6ba0203988f19e2f9426146b9b83f4aea9243712058", async() => {
                WriteLiteral("<i class=\"bi bi-eye\"></i>Details ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6ba0203988f19e2f9426146b9b83f4aea9243714412", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n");
#nullable restore
#line 43 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 45 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n\n        </table>\n\n    </div>\n</div>\n\n");
#nullable restore
#line 53 "E:\Esoft LMU\Application Development\CW2\Apps\Draft 5\eBooks\eTickets\Views\Publishers\Index.cshtml"
Write(await Html.PartialAsync("_CreateItem", "Publishers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
