#pragma checksum "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a1a6bb29cbddd6f4e6e80a36376082b7f7daf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminDashboard), @"mvc.1.0.view", @"/Views/Admin/AdminDashboard.cshtml")]
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
#line 1 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\_ViewImports.cshtml"
using MRTOnlineTicketingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\_ViewImports.cshtml"
using MRTOnlineTicketingSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a1a6bb29cbddd6f4e6e80a36376082b7f7daf2", @"/Views/Admin/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee216b29dde80e13934f13b04dfa63a762c1b45", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MRTOnlineTicketingSystem.Models.MRTTicket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" margin-left: auto; margin-right: auto; padding-bottom:30px; width: 100%; height:20%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7a1a6bb29cbddd6f4e6e80a36376082b7f7daf24911", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
     if (ViewBag.Name != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card\">\r\n            <h3 class=\"text-center\">Welcome back, ");
#nullable restore
#line 13 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
                                             Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" !</h3>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <br />

    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""collapse navbar-collapse"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">Admin Dashboard <span class=""sr-only"">(current)</span></a>
                </li>
                <li>
                    <a class=""nav-link"" href=""Visitor"">Statistic</a>

                </li>

            </ul>


");
#nullable restore
#line 33 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
             using (Html.BeginForm("AdminDashboard", "Admin", FormMethod.Get, new { @class = "form-inline my-6 my-lg-0" }))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <label></label>\r\n");
#nullable restore
#line 36 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.TextBox("SearchString", null, new { @class = "  form-control", @placeholder = "Search Email or Name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"submit\" class=\"btn btn-outline-success my-2 my-sm-0\" value=\"submit\" />\r\n");
#nullable restore
#line 39 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            &nbsp;\r\n            <a class=\"btn btn-outline-primary my-2 my-sm-0\" href=\"AdminDashboard\">Clear</a>\r\n            &nbsp;\r\n");
#nullable restore
#line 44 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
             if (ViewBag.UserEmail != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
                 using (Html.BeginForm("Logout", "Admin", FormMethod.Get, new { @class = "form-inline my-6 my-lg-0" }))
                {



#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"submit\" class=\"btn btn-outline-danger my-2 my-sm-0\" value=\"Logout\" />\r\n");
#nullable restore
#line 51 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </nav>\r\n    <header>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7a1a6bb29cbddd6f4e6e80a36376082b7f7daf29214", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </header>\r\n    <br />\r\n    <table class=\"table\" id=\"table_id\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>");
#nullable restore
#line 64 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.DisplayNameFor(x => x.PurchaseDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 65 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.DisplayNameFor(x => x.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 66 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.DisplayNameFor(x => x.CustomerEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 67 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.DisplayNameFor(x => x.CurrentLocationIndex));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 68 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.DisplayNameFor(x => x.DestinationLocationIndex));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 69 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           Write(Html.DisplayNameFor(x => x.TotalAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>Action</th>\r\n        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
           int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 76 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 77 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
                  
                    i++;
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>");
#nullable restore
#line 80 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.DisplayFor(y => x._PurchaseDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.DisplayFor(y => x.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.DisplayFor(y => x.CustomerEmail));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 83 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.DisplayFor(y => x.DictStation[x.CurrentLocationIndex]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 84 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.DisplayFor(y => x.DictStation[x.DestinationLocationIndex]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 85 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.DisplayFor(y => x._TotalAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 86 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = x.Invoiceid }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    ");
#nullable restore
#line 91 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\AdminDashboard.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("AdminDashboard", new { Page = page }),
    new PagedListRenderOptions
        {
        PageClasses = new[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MRTOnlineTicketingSystem.Models.MRTTicket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
