#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6ad1c50064b78e57bb18b2116cbe99ba0cb5ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Create), @"mvc.1.0.view", @"/Views/Reservations/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/Create.cshtml", typeof(AspNetCore.Views_Reservations_Create))]
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
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 3 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6ad1c50064b78e57bb18b2116cbe99ba0cb5ed", @"/Views/Reservations/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml"
  
    Layout = "~/Views/Catalogs/DumbLayout.cshtml";
    ViewData["title"] = "Đặt mua";

#line default
#line hidden
            BeginContext(216, 25, true);
            WriteLiteral("<div class=\"container\">\r\n");
            EndContext();
            BeginContext(241, 1219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8285ed0bab394222a05408aa9ab7d000", async() => {
                BeginContext(278, 42, true);
                WriteLiteral("\r\n      <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(320, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9a999877965413d9cd46e0f363edd73", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ViewBag.msg;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(373, 199, true);
                WriteLiteral("\r\n        <label for=\"\">\r\n            Mã căn hộ\r\n        </label>\r\n            <input type=\"text\" name=\"ApartmentCode\" id=\"ApartmentCode\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 572, "\"", 593, 1);
#line 15 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml"
WriteAttributeValue("", 580, ViewBag.code, 580, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(594, 732, true);
                WriteLiteral(@" required>
        </div>
        <div class=""form-group"">
            <label>Nhập số cmnd</label>
            <input type=""text"" id=""Cmnd"" name=""Cmnd"" class=""form-control"" placeholder="""" aria-describedby=""helpId"" required>
        </div>
        <div class=""form-group"">
            <label>Nhập SĐT</label>
            <input type=""text"" id=""PhoneNumber"" name=""PhoneNumber"" class=""form-control"" placeholder="""" aria-describedby=""helpId"" required>
        </div>
        <div class=""form-group"">
            <label>Nhập mã</label>
            <input type=""text"" id=""RCode"" name=""RCode"" class=""form-control"" placeholder="""" aria-describedby=""helpId"" required>
        </div>
        <div class=""form-group"">
            ");
                EndContext();
                BeginContext(1327, 40, false);
#line 30 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Reservations\Create.cshtml"
       Write(Html.Recaptcha(RecaptchaSettings?.Value));

#line default
#line hidden
                EndContext();
                BeginContext(1367, 86, true);
                WriteLiteral("\r\n        </div>\r\n        <button class=\"btn btn-success\" id=\"btn\">Xác nhận</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1460, 114, true);
            WriteLiteral("\r\n</div>\r\n<style>\r\n    .container {\r\n        padding-top: 40px;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RecaptchaSettings> RecaptchaSettings { get; private set; }
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
