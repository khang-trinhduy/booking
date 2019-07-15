#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721980a14ac92d18b9f7a4c67a5d3c517e302d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Batch_Create), @"mvc.1.0.view", @"/Views/Batch/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Batch/Create.cshtml", typeof(AspNetCore.Views_Batch_Create))]
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
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\_ViewImports.cshtml"
using BookingForm;

#line default
#line hidden
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\_ViewImports.cshtml"
using BookingForm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721980a14ac92d18b9f7a4c67a5d3c517e302d26", @"/Views/Batch/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Batch_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.BatchCreateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
  
    ViewData["title"] = "";
    Layout = "/Views/Confirmations/DumbLayout.cshtml";

#line default
#line hidden
            BeginContext(136, 174, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <label>The following apartments will be add to this batch</label>\r\n            <ul>\r\n");
            EndContext();
#line 11 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
                 foreach (var item in Model.Apartment)
                {

#line default
#line hidden
            BeginContext(385, 97, true);
            WriteLiteral("                    <li>\r\n                        <input type=\"checkbox\" checked disabled/><span>");
            EndContext();
            BeginContext(483, 14, false);
#line 14 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
                                                                  Write(item.LocalCode);

#line default
#line hidden
            EndContext();
            BeginContext(497, 37, true);
            WriteLiteral("</span>\r\n                    </li> \r\n");
            EndContext();
#line 16 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
                }

#line default
#line hidden
            BeginContext(553, 158, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <label>The following codes will be valid on this batch</label>\r\n            <ul>\r\n");
            EndContext();
#line 22 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
                 foreach (var item in Model.Code)
                {

#line default
#line hidden
            BeginContext(781, 97, true);
            WriteLiteral("                    <li>\r\n                        <input type=\"checkbox\" checked disabled/><span>");
            EndContext();
            BeginContext(879, 9, false);
#line 25 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
                                                                  Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(888, 37, true);
            WriteLiteral("</span>\r\n                    </li> \r\n");
            EndContext();
#line 27 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Batch\Create.cshtml"
                }

#line default
#line hidden
            BeginContext(944, 51, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(995, 397, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2cbc70673d9440a86e4229334fb2d76", async() => {
                BeginContext(1021, 364, true);
                WriteLiteral(@"
        <div class=""form-check"" hidden>
        <label class=""form-check-label"">
            
            <input type=""checkbox"" class=""form-check-input"" name=""IsRunning"" id=""IsRunning"" checked=""true"">
            This batch will be set to running
        </label>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Create</button>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1392, 85, true);
            WriteLiteral("\r\n</div>\r\n<style>\r\n    .container {\r\n        padding: 25px 0 25px 0;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.BatchCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591