#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236710318d7dbc7d875b728239e999f8596fc6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Detail), @"mvc.1.0.view", @"/Views/Catalogs/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogs/Detail.cshtml", typeof(AspNetCore.Views_Catalogs_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236710318d7dbc7d875b728239e999f8596fc6c0", @"/Views/Catalogs/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Apartment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
  
    ViewData["title"] = "Chi tiết sản phẩm";
    Layout = "~/Views/Catalogs/DumbLayout.cshtml";

#line default
#line hidden
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(144, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f4c12191ed84ab7b3ce0a35cdc6b65d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
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
            BeginContext(197, 121, true);
            WriteLiteral("\r\n<h1>Thông tin sản phẩm</h1>\r\n</hr>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      Tên sản phẩm :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(319, 10, false);
#line 14 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(329, 64, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(394, 45, false);
#line 18 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.NOBedroom));

#line default
#line hidden
            EndContext();
            BeginContext(439, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(461, 15, false);
#line 20 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.NOBedroom);

#line default
#line hidden
            EndContext();
            BeginContext(476, 64, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(541, 40, false);
#line 24 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.NOWC));

#line default
#line hidden
            EndContext();
            BeginContext(581, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(603, 10, false);
#line 26 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.NOWC);

#line default
#line hidden
            EndContext();
            BeginContext(613, 66, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(680, 41, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(721, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(743, 11, false);
#line 33 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.Floor);

#line default
#line hidden
            EndContext();
            BeginContext(754, 64, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(819, 45, false);
#line 37 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Direction));

#line default
#line hidden
            EndContext();
            BeginContext(864, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(886, 15, false);
#line 39 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.Direction);

#line default
#line hidden
            EndContext();
            BeginContext(901, 64, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(966, 40, false);
#line 43 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(1028, 10, false);
#line 45 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.Area);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 66, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1105, 41, false);
#line 50 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.Block));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(1168, 11, false);
#line 52 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.Block);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 88, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      Giá :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(1268, 11, false);
#line 58 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1279, 66, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1346, 45, false);
#line 63 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.LocalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(1413, 15, false);
#line 65 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.LocalCode);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 64, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"form-group\">\r\n  <label for=\"\">\r\n      ");
            EndContext();
            BeginContext(1493, 46, false);
#line 69 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
 Write(Html.DisplayNameFor(model => model.GlobalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 21, true);
            WriteLiteral(" :\r\n  </label>\r\n  <p>");
            EndContext();
            BeginContext(1561, 16, false);
#line 71 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
Write(Model.GlobalCode);

#line default
#line hidden
            EndContext();
            BeginContext(1577, 100, true);
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"hideable\">\r\n  <input type=\"button\" class=\"btn btn-default\" value=\"Đặt mua\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1677, "\"", 1768, 3);
            WriteAttributeValue("", 1687, "location.href=\'", 1687, 15, true);
#line 74 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Detail.cshtml"
WriteAttributeValue("", 1702, Url.Action("Proceed", "Catalogs", new {code = @Model.LocalCode}), 1702, 65, false);

#line default
#line hidden
            WriteAttributeValue("", 1767, "\'", 1767, 1, true);
            EndWriteAttribute();
            BeginContext(1769, 739, true);
            WriteLiteral(@" />
</div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<script>
    $('#btn').on('click', function() {
      swal({
      title: ""Bạn có chắc chắn chọn mua căn này?"",
      text: ""Mỗi mã chỉ được sử dụng một lần. Quý khách sẽ không được thay đổi căn sau khi đã chọn!"",
      icon: ""warning"",
      buttons: true,
      dangerMode: true,
    })
    .then((willBuy) => {
      if (willBuy) {
        swal(""Hệ thống đã nhận được yêu cầu của bạn, đang tiến hành xử lý!"", {
          icon: ""success"",
        });
        $('#form').submit();
      } else {
        
      }
    });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Apartment> Html { get; private set; }
    }
}
#pragma warning restore 1591
