#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6666929dee1955b0f02fd24b4e9c0e6f681b1d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contacts.cshtml", typeof(AspNetCore.Views_Home_Contacts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6666929dee1955b0f02fd24b4e9c0e6f681b1d16", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Views", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contracts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 131, true);
            WriteLiteral("\r\n<span style=\"display:inline-block; height: 15px;\"></span>\r\n<h6 style=\"font-style:italic; text-align:right\">TP. Hồ Chí Minh, ngày ");
            EndContext();
            BeginContext(180, 16, false);
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                                                                 Write(DateTime.Now.Day);

#line default
#line hidden
            EndContext();
            BeginContext(196, 8, true);
            WriteLiteral("  tháng ");
            EndContext();
            BeginContext(205, 18, false);
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                                                                                          Write(DateTime.Now.Month);

#line default
#line hidden
            EndContext();
            BeginContext(223, 5, true);
            WriteLiteral(" năm ");
            EndContext();
            BeginContext(229, 17, false);
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                                                                                                                  Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(246, 617, true);
            WriteLiteral(@"</h6>
<span style=""display:inline-block; height: 15px;""></span>
<h4 style=""text-align:center;font-family:Calibri"">Danh sách khách hàng</h4>
<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    STT
                </th>
                <th>
                    Họ & tên
                </th>
                <th>
                    Ngày cung cấp
                </th>
                <th>
                    Tình trạng
                </th>

                <th>
                    Sales chăm sóc
                </th>

");
            EndContext();
            BeginContext(1122, 81, true);
            WriteLiteral("                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
              int count = 1; 

#line default
#line hidden
            BeginContext(1235, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 42 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
             foreach (Contact item in Model)
            {

#line default
#line hidden
            BeginContext(1296, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1343, 5, false);
#line 45 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 81, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:left\">\r\n                        ");
            EndContext();
            BeginContext(1430, 39, false);
#line 47 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(1893, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1944, 40, false);
#line 59 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PDate));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2064, 44, false);
#line 62 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Condition));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(2534, 50, true);
            WriteLiteral("                    <td style=\"text-align:left\">\r\n");
            EndContext();
#line 74 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                         if (item.SupporterId != null)
                        {
                            /**/
                            

#line default
#line hidden
            BeginContext(2730, 49, false);
#line 77 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Supporter.Name));

#line default
#line hidden
            EndContext();
#line 77 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                                                                              
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2865, 52, true);
            WriteLiteral("                            <p>Công ty sắp xếp</p>\r\n");
            EndContext();
#line 82 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                        }

#line default
#line hidden
            BeginContext(2944, 27, true);
            WriteLiteral("                    </td>\r\n");
            EndContext();
            BeginContext(3524, 34, true);
            WriteLiteral("                    <td id=\"hh\">\r\n");
            EndContext();
#line 98 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                         if (item.AppoinmentId != null)
	                    {

#line default
#line hidden
            BeginContext(3639, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3667, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7491331accae4fc3a3589a99e5e2d852", async() => {
                BeginContext(3740, 6, true);
                WriteLiteral("Xem HĐ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                                                                     WriteLiteral(item.AppoinmentId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3750, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 101 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3836, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3864, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd6a9eb5ad844569e06e15f1501bf08", async() => {
                BeginContext(3931, 6, true);
                WriteLiteral("Tạo HĐ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 104 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3941, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 105 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                        }                       

#line default
#line hidden
            BeginContext(3993, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(4169, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 110 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Contacts.cshtml"
                count++;
            }

#line default
#line hidden
            BeginContext(4262, 806, true);
            WriteLiteral(@"        </tbody>
    </table>


    <h5 style=""color:red; font-style:italic"">Lưu ý:</h5>
    <ul style=""list-style:circle"">
        <li style=""color:red; font-style:italic"">(*)Mức hoa hồng dự kiến: là tỷ lệ hoa hồng được ghi nhận trước cho CTV ngay khi cung cấp thông tin. Tỷ lệ này có thể bị thay đổi khi CTV cung cấp thông tin không chính xác và sẽ được chuyển thành tỷ lệ hoa hồng thực tế sau khi KH giao dịch thành công.</li>
        <li style=""color:red; font-style:italic"">(**)Mức hoa hồng thực tế: là tỷ lệ hoa hồng sẽ được chi trả cho CTV sau khi khách hàng giao dịch thành công.</li>
        <li style=""color:red; font-style:italic"">Giao dịch thành công: Khi KH do CTV cung cấp đã kí hợp đồng mua bán căn hộ và thanh toán tối thiểu 30% GTCH theo quy định của CĐT.</li>

    </ul>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
