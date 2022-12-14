#pragma checksum "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ffd6b9674611e061476b8efa922b6bc91d41932"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ffd6b9674611e061476b8efa922b6bc91d41932", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee216b29dde80e13934f13b04dfa63a762c1b45", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MRTOnlineTicketingSystem.Models.MRTTicket>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ffd6b9674611e061476b8efa922b6bc91d419323344", async() => {
                WriteLiteral("\r\n    <title>Summary</title>\r\n    <style>\r\n        label {\r\n            width: 200px;\r\n            float: left;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ffd6b9674611e061476b8efa922b6bc91d419324460", async() => {
                WriteLiteral("\r\n    <h1>Ticket Summary</h1>\r\n    <br />\r\n    <h3>Station</h3>\r\n    <p>\r\n        <label>");
#nullable restore
#line 16 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
          Write(Html.DisplayNameFor(x => x.PurchaseDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n        ");
#nullable restore
#line 17 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
   Write(Html.DisplayFor(x => x.PurchaseDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n    <div class=\"row\">\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 21 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.CurrentLocationIndex));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 22 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x.DictStation[Model.CurrentLocationIndex]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 29 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.DestinationLocationIndex));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 30 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x.DictStation[Model.DestinationLocationIndex]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"row\">\r\n\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 36 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.TicketIndex));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 37 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x.DictTicketType[Model.TicketIndex]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <h3>Ticket Quantity</h3>\r\n    <div class=\"row\">\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 43 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.Adult));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 44 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x.Adult));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"row\">\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 49 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.SeniorCitizen));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 50 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x.SeniorCitizen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div class=\"row\">\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 55 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.Disable));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 56 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x.Disable));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <h3>Price</h3>\r\n    <div class=\"row\">\r\n        <p class=\"col-md-4\">\r\n            <label>");
#nullable restore
#line 62 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
              Write(Html.DisplayNameFor(x => x.TotalAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>:\r\n            ");
#nullable restore
#line 63 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
       Write(Html.DisplayFor(x => x._TotalAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 68 "C:\Users\Arthuria\Documents\GitHub\MRTOnlineTicketingSystem\MRTOnlineTicketingSystem\Views\Admin\Details.cshtml"
   Write(Html.ActionLink("Back to Admin Dashboard", "AdminDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MRTOnlineTicketingSystem.Models.MRTTicket> Html { get; private set; }
    }
}
#pragma warning restore 1591
