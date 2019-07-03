#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1149559bd97d6f905782042c5cc668605923aafa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Confirmations_Confirm), @"mvc.1.0.view", @"/Views/Confirmations/Confirm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Confirmations/Confirm.cshtml", typeof(AspNetCore.Views_Confirmations_Confirm))]
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
#line 3 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1149559bd97d6f905782042c5cc668605923aafa", @"/Views/Confirmations/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Confirmations_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.ConfirmationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
  
  Layout = null;

#line default
#line hidden
            BeginContext(195, 1878, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be4d67091f1b47388882d462746f1cd3", async() => {
                BeginContext(201, 1582, true);
                WriteLiteral(@"
  <title>Xác nhận thông tin</title>
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
  <style>
    h1 {
      margin-top: 65px;
      font-family: sans-serif;
      font-size: 40;
      color: #595f65;
    }

    p {
      font-family: sans-serif;
      font-size: 18;
      color: #828486;
    }

    h3 {
      font-size: 28;
      font-family: sans-serif;
");
                WriteLiteral(@"      color: #6f767d;
      margin-top: 35px;
    }

    h4 {
      font-family: sans-serif;
      font-size: 21;
      color: #46494c;
    }

    h1,
    h3,
    h4,
    p {
      margin-left: 11px;
    }

    a {
      color: #595f65;
    }

    #product,
    #order {
      background-color: #f7f7f7;
      margin-left: 11px;
      margin-right: 11px;
      padding: 0 14 0 14;
    }

    #product>p,
    #order>p {
      margin: 18 0 18 0;
    }

    #product>h4,
    #order>h4 {
      margin: 0 0 18 0;
    }

    ");
                EndContext();
                BeginContext(1784, 282, true);
                WriteLiteral(@"@media only screen and (min-width: 1280px) {
      body {
        margin: 0 400 20 400;
      }

      h5 {
        font-family: sans-serif;
        font-size: 15px;
        color: red;
        font-style: italic;
        margin-left: 14px;

      }
    }
  </style>
");
                EndContext();
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
            EndContext();
            BeginContext(2073, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2075, 1844, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbb4ac9a7b0b465bbb860dce96f5f4b9", async() => {
                BeginContext(2081, 227, true);
                WriteLiteral("\r\n<hr />\r\n<hr />\r\n<!-- <h1 style=\"font-family:sans-serif; \">Chúc mừng bạn đã đặt mua thành công!</h1>\r\n<p>Đơn hàng của bạn đã được hệ thông tiếp nhận</p> -->\r\n<h3>Thông tin khách hàng</h3>\r\n<div id=\"product\">\r\n    <p>Họ & tên: ");
                EndContext();
                BeginContext(2309, 21, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
            Write(Model.Client.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(2330, 18, true);
                WriteLiteral(" / Số điện thoại: ");
                EndContext();
                BeginContext(2349, 24, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                                                    Write(Model.Client.PhoneNumber);

#line default
#line hidden
                EndContext();
                BeginContext(2373, 12, true);
                WriteLiteral(" / Số cmnd: ");
                EndContext();
                BeginContext(2386, 17, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                                                                                         Write(Model.Client.Cmnd);

#line default
#line hidden
                EndContext();
                BeginContext(2403, 70, true);
                WriteLiteral("</p>\r\n</div>\r\n<h3>Thông tin sản phẩm</h3>\r\n<div id=\"product\">\r\n    <p>");
                EndContext();
                BeginContext(2474, 25, false);
#line 97 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
  Write(Model.Apartment.LocalCode);

#line default
#line hidden
                EndContext();
                BeginContext(2499, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(2503, 20, false);
#line 97 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                               Write(Model.Apartment.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2523, 27, true);
                WriteLiteral("</p>\r\n    <p>Số phòng ngủ: ");
                EndContext();
                BeginContext(2551, 25, false);
#line 98 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                Write(Model.Apartment.NOBedroom);

#line default
#line hidden
                EndContext();
                BeginContext(2576, 21, true);
                WriteLiteral(" / Số phòng vệ sinh: ");
                EndContext();
                BeginContext(2598, 20, false);
#line 98 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                                                               Write(Model.Apartment.NOWC);

#line default
#line hidden
                EndContext();
                BeginContext(2618, 20, true);
                WriteLiteral("</p>\r\n    <p>Hướng: ");
                EndContext();
                BeginContext(2639, 25, false);
#line 99 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
         Write(Model.Apartment.Direction);

#line default
#line hidden
                EndContext();
                BeginContext(2664, 9, true);
                WriteLiteral(" / View: ");
                EndContext();
                BeginContext(2674, 20, false);
#line 99 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                                            Write(Model.Apartment.View);

#line default
#line hidden
                EndContext();
                BeginContext(2694, 9, true);
                WriteLiteral(" / Tầng: ");
                EndContext();
                BeginContext(2704, 21, false);
#line 99 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                                                                          Write(Model.Apartment.Floor);

#line default
#line hidden
                EndContext();
                BeginContext(2725, 14, true);
                WriteLiteral(" / Diện tích: ");
                EndContext();
                BeginContext(2740, 20, false);
#line 99 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
                                                                                                              Write(Model.Apartment.Area);

#line default
#line hidden
                EndContext();
                BeginContext(2760, 82, true);
                WriteLiteral("</p>\r\n</div>\r\n<h3>Thông tin đặt chỗ</h3>\r\n<div id=\"product\">\r\n    <p>Mã xác nhận: ");
                EndContext();
                BeginContext(2843, 17, false);
#line 103 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
               Write(Model.Reserve.RCC);

#line default
#line hidden
                EndContext();
                BeginContext(2860, 16, true);
                WriteLiteral("</p>\r\n</div>\r\n\r\n");
                EndContext();
                BeginContext(2876, 1000, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "336006c9f6004bb68f1a7fcbd9dac5fd", async() => {
                    BeginContext(2913, 51, true);
                    WriteLiteral("\r\n        <div class=\"form-group\" hidden>\r\n        ");
                    EndContext();
                    BeginContext(2964, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c2c60639db84b3f8222fff6f5096255", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 108 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
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
                    BeginContext(3017, 97, true);
                    WriteLiteral("\r\n        <label for=\"\">\r\n            Mã căn hộ\r\n        </label>\r\n            <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3114, "\"", 3146, 1);
#line 112 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
WriteAttributeValue("", 3122, Model.Confirm.LocalCode, 3122, 24, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3147, 233, true);
                    WriteLiteral(" name=\"LocalCode\" id=\"LocalCode\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\" required>\r\n        </div>\r\n        <div class=\"form-group\" hidden>\r\n            <label>Mã xác nhận</label>\r\n            <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3380, "\"", 3406, 1);
#line 116 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
WriteAttributeValue("", 3388, Model.Confirm.RCC, 3388, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3407, 146, true);
                    WriteLiteral(" id=\"RCC\" name=\"RCC\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\" required>\r\n        </div>\r\n        \r\n        <input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3553, "\"", 3584, 1);
#line 119 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
WriteAttributeValue("", 3561, Model.Confirm.ClientId, 3561, 23, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3585, 157, true);
                    WriteLiteral(" id=\"ClientId\" name=\"ClientId\" class=\"form-control\" placeholder=\"\" aria-describedby=\"helpId\" required hidden>\r\n        <div class=\"form-group\">\r\n            ");
                    EndContext();
                    BeginContext(3743, 40, false);
#line 121 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Confirmations\Confirm.cshtml"
       Write(Html.Recaptcha(RecaptchaSettings?.Value));

#line default
#line hidden
                    EndContext();
                    BeginContext(3783, 86, true);
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
                BeginContext(3876, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(3880, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac160624a179474885e53f5980aabe41", async() => {
                    BeginContext(3903, 3, true);
                    WriteLiteral("Hủy");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3910, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3919, 790, true);
            WriteLiteral(@"
<style>
    
    p {
      font-family: sans-serif;
      font-size: 18;
      color: #828486;
    }

    h3 {
      font-size: 28;
      font-family: sans-serif;
      color: #6f767d;
      margin-top: 35px;
    }

    h4 {
      font-family: sans-serif;
      font-size: 21;
      color: #46494c;
    }

    h1,
    h3,
    h4,
    p {
      margin-left: 11px;
    }

    a {
      color: #595f65;
    }

    <!-- #product,
    #order {
      background-color: #f7f7f7;
      margin-left: 11px;
      margin-right: 11px;
      padding: 6 14 6 14;
    }

    #product>p,
    #order>p {
      margin: 18 0 18 0;
    }

    #product>h4,
    #order>h4 {
      margin: 0 0 18 0;
    } -->

    body {
      margin-bottom: 20;
    }

    ");
            EndContext();
            BeginContext(4710, 267, true);
            WriteLiteral(@"@media only screen and (min-width: 1280px) {
      body {
        margin: 0 400 0 400;
      }

    }
    h5 {
      font-family: sans-serif;
      font-size: 15px;
      color: red;
      font-style: italic;
      margin-left: 14px;

    }
  </style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.ConfirmationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
