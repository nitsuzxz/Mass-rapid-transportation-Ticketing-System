#pragma checksum "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d203bc1c3a8909bb6f570ca5956b00ddb293b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d203bc1c3a8909bb6f570ca5956b00ddb293b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee216b29dde80e13934f13b04dfa63a762c1b45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to MRT Websites</h1>\r\n\r\n    <br />\r\n    <h2>Please choose </h2>\r\n    <p><button type=\"button\">");
#nullable restore
#line 10 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Home\Index.cshtml"
                        Write(Html.ActionLink("Admin Page", "AdminLogin", "Admin", null, new { target = "_blank" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></p>\r\n    <h2>or </h2>\r\n    <p><button type=\"button\"> ");
#nullable restore
#line 12 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Home\Index.cshtml"
                         Write(Html.ActionLink("User Page", "UserHome"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></p>\r\n\r\n</div>\r\n");
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
