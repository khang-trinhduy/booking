#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b2364be10e09670290f92fcfbccab0e477c7be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appoinments_Views), @"mvc.1.0.view", @"/Views/Appoinments/Views.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appoinments/Views.cshtml", typeof(AspNetCore.Views_Appoinments_Views))]
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
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b2364be10e09670290f92fcfbccab0e477c7be", @"/Views/Appoinments/Views.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Appoinments_Views : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Appoinment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block;margin-left:auto;margin-right:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/logo.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:119px;width:160px; margin-left:12.5%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/sign.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
  
    var curUser = await UserManager.GetUserAsync(User);
    ViewData["Title"] = "HĐ -";

#line default
#line hidden
            BeginContext(212, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b7ef6f70d4744a29334a08975af40a8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 8 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 187, true);
            WriteLiteral("\r\n<div>\r\n    <h4 style=\"font-weight:bold;text-align:center\">PHIẾU ĐĂNG KÝ GIỮ CHỖ - VINHOMNES GRAND PARK</h4>\r\n    <p style=\"font-style:italic; font-weight:bold; text-align:center\">( Số: ");
            EndContext();
            BeginContext(515, 14, false);
#line 11 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                       Write(Model.Contract);

#line default
#line hidden
            EndContext();
            BeginContext(529, 24, true);
            WriteLiteral("/2019/DKGC-VINGP )</p>\r\n");
            EndContext();
#line 12 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
      
        string day, month, year = "";
        try
        {
            DateTime d = DateTime.ParseExact(Model.cTime, "ddMMyyyy HH:mm:ss.FFFFFFF",
                             System.Globalization.CultureInfo.InvariantCulture);
            day = Convert.ToString(d.Day);
            month = Convert.ToString(d.Month);
            year = Convert.ToString(d.Year);
        }
        catch (Exception)
        {

            day = "...";
            month = "...";
            year = "...";
        }

    

#line default
#line hidden
            BeginContext(1084, 74, true);
            WriteLiteral("    <h6 style=\"font-style:italic; text-align:right\">TP. Hồ Chí Minh, ngày ");
            EndContext();
            BeginContext(1159, 3, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                     Write(day);

#line default
#line hidden
            EndContext();
            BeginContext(1162, 8, true);
            WriteLiteral("  tháng ");
            EndContext();
            BeginContext(1171, 5, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                                 Write(month);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 5, true);
            WriteLiteral(" năm ");
            EndContext();
            BeginContext(1182, 4, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                                            Write(year);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 985, true);
            WriteLiteral(@"</h6>
    <h5 style=""font-weight:bold; text-align:left"">BÊN A: CÔNG TY CỔ PHẦN NHÀ ANN HOME</h5>
    <p>Chi nhánh	:	311 K25 đường số 8, khu phố 1, phường An Phú, Quận 2, TP. Hồ Chí Minh</p>
    <p>
        Đ/c giao dịch	:	Khu nhà mẫu Vinhomes Grand Park, tầng 3 Vincom Mega Mall, Quận 2, TP.HCM
    </p>
    <p>Mã số thuế	:	0314251205</p>
    <p style=""display: inline;"">Đại diện bởi  	:</p><p style=""display: inline; font-weight: bold;"">	Bà Lê Thị Thu Hằng<span style=""display:inline-block; width: 100px;""></span></p><p style=""display:inline;"">Chức vụ:  	Tổng Giám Đốc</p>
    <p>Điện thoại	:	0867.3014.666<span style=""display:inline-block; width: 150px;""></span>Hotline: 0902 969 169</p>
    <p>Email	:	hello@annhome.vn<span style=""display:inline-block; width: 150px;""></span>Website: https://www.annhome.vn</p>
    <p style=""font-style:italic"">(Sau đây gọi là Bên A)</p>
    <h5 style=""font-weight:bold; text-align:left"">BÊN B: THÔNG TIN KHÁCH HÀNG</h5>
    <p>Ông/bà	: ");
            EndContext();
            BeginContext(2172, 40, false);
#line 43 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
              Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
      
        string tmp_day = "../../....";
        try
        {
            tmp_day = Model.Day.ToString("dd/MM/yyyy");
        }
        catch (Exception)
        {
        }
    

#line default
#line hidden
            BeginContext(2414, 28, true);
            WriteLiteral("    <p>Số CMND (hộ chiếu)\t: ");
            EndContext();
            BeginContext(2443, 36, false);
#line 54 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                          Write(Html.DisplayFor(model => model.Cmnd));

#line default
#line hidden
            EndContext();
            BeginContext(2479, 67, true);
            WriteLiteral("\t<span style=\"display:inline-block; width: 70px;\"></span>Ngày cấp: ");
            EndContext();
            BeginContext(2547, 7, false);
#line 54 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                                                                                     Write(tmp_day);

#line default
#line hidden
            EndContext();
            BeginContext(2554, 65, true);
            WriteLiteral("<span style=\"display:inline-block; width: 70px;\"></span>Nơi cấp:\t");
            EndContext();
            BeginContext(2620, 37, false);
#line 54 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                                                                                                                                                                 Write(Html.DisplayFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 34, true);
            WriteLiteral("</p>\r\n    <p>Hộ khẩu thường trú\t: ");
            EndContext();
            BeginContext(2692, 36, false);
#line 55 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                          Write(Html.DisplayFor(model => model.HKTT));

#line default
#line hidden
            EndContext();
            BeginContext(2728, 31, true);
            WriteLiteral("</p>\r\n    <p>Địa chỉ liên hệ\t: ");
            EndContext();
            BeginContext(2760, 39, false);
#line 56 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2799, 26, true);
            WriteLiteral("</p>\r\n    <p>Điện thoại\t: ");
            EndContext();
            BeginContext(2826, 37, false);
#line 57 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                  Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2863, 21, true);
            WriteLiteral("</p>\r\n    <p>Email\t: ");
            EndContext();
            BeginContext(2885, 37, false);
#line 58 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 60 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
      
        string borrow = "Nhu cầu vay NH: ";
        if (Model.Price > 0)
        {
            borrow += "Có   Số tiền: " + string.Format("{0:N0}", Model.Price) + " VNĐ";
        }
        else
        {
            borrow += "Không";
        }
    

#line default
#line hidden
            BeginContext(3199, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(3217, 16, false);
#line 72 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
   Write(Html.Raw(borrow));

#line default
#line hidden
            EndContext();
            BeginContext(3233, 601, true);
            WriteLiteral(@"
    </p>
    <p>Khả năng thanh toán: Thanh toán 100% / Thanh toán theo tiến độ</p>
    <p>Các Bên thống nhất lập và ký kết phiếu đăng ký giữ chỗ này sau khi có xác nhận bên B thanh toán đầy đủ số tiền giữ chỗ cho bên A thông qua chuyển khoản hoặc tiền mặt để đảm bảo việc tham gia đăng ký mua sản phẩm bất động sản tại Dự Án Vinhomes Grand Park với các nội dung sau đây:</p>
    <h5 style=""font-weight:bold"">Điều 1. Nội dung thỏa thuận</h5>
    <p style=""font-weight:bold"">1.1.	Thông tin loại sản phẩm bất động sản đăng ký tham gia chọn mua:</p>
    <ul style=""list-style-type: lower-alpha;"">
");
            EndContext();
#line 79 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
          
            var str = "";
            if (@Model.NCH1 > 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 1 phòng ngủ:</p><p>-	Số lượng căn: 0" + @Model.NCH1 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
            if (@Model.NCH2 > 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 2 phòng ngủ 1 phòng vệ sinh:</p><p>-	Số lượng căn: 0" + @Model.NCH2 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
            if (@Model.NCH21 > 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 2 phòng ngủ 2 phòng vệ sinh:</p><p>-	Số lượng căn: 0" + @Model.NCH21 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
            if (@Model.NCH3 > 0)
            {
                str += "<li><p style=\"font-weight:bold\">Căn Hộ 3 phòng ngủ:</p><p>-	Số lượng căn: 0" + @Model.NCH3 + "……………Tầng:………………</p><p>-	Hướng  ………………    View………………</p></li>";
            }
        

#line default
#line hidden
            BeginContext(4914, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(4923, 13, false);
#line 98 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
   Write(Html.Raw(str));

#line default
#line hidden
            EndContext();
            BeginContext(4936, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
          
            if (Model.NSH > 0)
            {

#line default
#line hidden
            BeginContext(4997, 238, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Biệt thự đơn lập:\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(5236, 9, false);
#line 106 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                   Write(Model.NSH);

#line default
#line hidden
            EndContext();
            BeginContext(5245, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 110 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
            }
            if (Model.NSH1 > 0)
            {

#line default
#line hidden
            BeginContext(5455, 239, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Biệt thự song lập:\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(5695, 10, false);
#line 117 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                   Write(Model.NSH1);

#line default
#line hidden
            EndContext();
            BeginContext(5705, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 121 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
            }
            if (Model.NSHH > 0)
            {

#line default
#line hidden
            BeginContext(5915, 238, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Shophouse (NPTM):\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(6154, 10, false);
#line 128 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                   Write(Model.NSHH);

#line default
#line hidden
            EndContext();
            BeginContext(6164, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 132 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
            }
            if (Model.NS > 0)
            {

#line default
#line hidden
            BeginContext(6372, 242, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Shop (kios chung cư):\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(6615, 8, false);
#line 139 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                   Write(Model.NS);

#line default
#line hidden
            EndContext();
            BeginContext(6623, 147, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n                <spans style=\"display:inline-block\"></spans>\r\n");
            EndContext();
#line 143 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
            }
            if (Model.NMS > 0)
            {

#line default
#line hidden
            BeginContext(6832, 230, true);
            WriteLiteral("                <li>\r\n                    <p style=\"font-weight:bold\">\r\n                        Dinh thự:\r\n                    </p><p style=\"display:inline\">-\tSố lượng căn: 0</p><p style=\"display:inline\">\r\n                        ");
            EndContext();
            BeginContext(7063, 9, false);
#line 150 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                   Write(Model.NMS);

#line default
#line hidden
            EndContext();
            BeginContext(7072, 85, true);
            WriteLiteral("……………Hướng:……………    View: ……………………\r\n                    </p>\r\n                </li>\r\n");
            EndContext();
#line 153 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
            }
        

#line default
#line hidden
            BeginContext(7183, 80, true);
            WriteLiteral("    </ul>\r\n    <p style=\"font-weight:bold\">1.2.\tSố tiền giữ chỗ đặt mua: &nbsp; ");
            EndContext();
            BeginContext(7264, 17, false);
#line 156 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                   Write(ViewBag.New_Money);

#line default
#line hidden
            EndContext();
            BeginContext(7281, 32, true);
            WriteLiteral("</p>\r\n    <p>( Bằng chữ: &nbsp; ");
            EndContext();
            BeginContext(7314, 21, false);
#line 157 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                     Write(ViewBag.Money_Letters);

#line default
#line hidden
            EndContext();
            BeginContext(7335, 3805, true);
            WriteLiteral(@" )</p>
    <p>Thời gian tính quyền ưu tiên của khách hàng sẽ căn cứ vào phiếu thu tiền mặt hoặc ủy nhiệm chi chuyển khoản</p>
    <h5 style=""font-weight:bold"">Điều 2.	Phương thức thanh toán</h5>
    <p>
        -	Bên B thanh toán số tiền đăng ký giữ chỗ nêu trên bằng tiền mặt hoặc chuyển khoản vào tài khoản Ngân hàng sau đây:
    <p style=""display:inline"">-	Tên tài khoản:</p><p style=""display:inline; font-weight:bold;""> Công ty Cổ Phần Nhà ANN HOME</p>
    <p style=""font-weight:bold; text-decoration:underline;"">
        Tại NH TMCP Việt Nam Thương Tín (Vietbank)
    </p>
    <ul style=""list-style:none;"">
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Số tài khoản<span style=""display:inline-block; width: 60px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> 14206377</p>
        </li>
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Tên Ngân hàng<span style=""display");
            WriteLiteral(@":inline-block; width: 41px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> Vietbank – CN Võ Văn Ngân - TP HCM</p>
        </li>
    </ul>
    <p style=""font-weight:bold; text-decoration:underline;"">Tại NH TMCP Ngoại Thương Việt Nam (Vietcombank)</p>
    <ul style=""list-style:none"">
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Số tài khoản<span style=""display:inline-block; width: 60px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> 0371000471407</p>
        </li>
        <li>
            <p style=""display:inline""><span style=""font-family:Wingdings"">&#x00d8;</span>	Tên Ngân hàng<span style=""display:inline-block; width: 41px;""></span>:</p>
            <p style=""display:inline; font-weight:bold""> Vietcombank - CN Tân Định - TP HCM</p>
        </li>
    </ul>
    <p style=""display:inline"">-	Nội dung: </p><p style=""display:inline; font-weight:bold;"">[Tên khách hàng] giữ chỗ [SL] [Sản phẩm] Vinhom");
            WriteLiteral(@"es Grand Park</p>
    <h5 style=""font-weight:bold"">Điều 3.	Điều khoản chung</h5><p>
        <ul class=""dashed"">
            <li>
                Phiếu đăng ký giữ chỗ này không phải là phiếu đặt cọc, không có giá trị pháp lý thay thế phiếu đặt cọc.
            </li>
            <li>
                Với phiếu đăng ký giữ chỗ này, Bên A nhận lời đặt giữ chỗ căn hộ nêu trên cho Bên B khi Chủ đầu tư mở bán chính thức. Bên A sẽ thông báo giá bán chính thức tới Bên B khi thỏa mãn các điều khoản của Chủ đầu tư và giá trị giữ chỗ sẽ trở thành tiền đặt cọc.
            </li>
            <li>
                Nếu bên B không đồng ý với giá bán căn hộ Chủ đầu đưa ra thì Bên A sẽ trả lại toàn bộ giá trị giữ chỗ cho Bên B trong vòng 07 ngày làm việc.
            </li>
            <li>
                Phiếu giữ chỗ này không còn giá trị khi bên B đã chính thức chuyển sang ký hợp đồng đặt cọc với chủ đầu tư.
            </li>
            <li>
                Phiếu này được lập thành 02 (hai) bản và có giá trị");
            WriteLiteral(@" như nhau. Bên A giữ 01 bản, Bên B giữ 01 bản để làm cơ sở thực hiện.
            </li>
        </ul>


    </p>
    <span style=""display:inline-block; width:13.6%""></span><h5 style=""text-align: left; width:35%; display: inline-block;font-weight:bold;"">ĐẠI DIỆN BÊN A</h5>
    <h5 style=""text-align: right; width:35%;  display: inline-block;font-weight:bold;"">ĐẠI DIỆN BÊN B</h5>
    <br />
    <span style=""display:inline-block; width:12.5%""></span><p style=""text-align: left;font-style:italic; width:35%; display: inline-block;"">(ký và ghi rõ họ tên)</p>
    <span style=""display:inline-block; width:2%""></span><p style=""text-align: right;font-style:italic; width:35%;  display: inline-block;"">(ký và ghi rõ họ tên)</p>
");
            EndContext();
            BeginContext(11452, 9, true);
            WriteLiteral("    <div>");
            EndContext();
            BeginContext(11461, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "040370b29d7f4b749dce8912a0af7825", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 216 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11570, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(11890, 301, true);
            WriteLiteral(@"    <span style=""display:inline-block; width:12.5%""></span><h5 style=""text-align: left; width:35%; display: inline-block;font-weight:bold;"">LÊ THỊ THU HẰNG</h5>
    <span style=""display:inline-block; width:2%""></span><h5 style=""text-align: right; width:35%;  display: inline-block;font-weight:bold;"">");
            EndContext();
            BeginContext(12192, 40, false);
#line 220 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                                                                                      Write(Html.DisplayFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(12232, 346, true);
            WriteLiteral(@"</h5>
    <span style=""display:inline-block; height: 15px;""></span>
    <h5 style=""font-weight:bold; text-align:center"">Nhân viên kinh doanh</h5>
    <p style=""font-style:italic; text-align:center"">(ký và ghi rõ họ tên)</p>
    <span style=""display:inline-block; height: 100px;""></span>
    <h5 style=""font-weight: bold;  text-align:center"">");
            EndContext();
            BeginContext(12579, 12, false);
#line 225 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                 Write(curUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(12591, 4182, true);
            WriteLiteral(@"</h5>
</div>
<div id=""log""></div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script>

    (function () {
    'use strict';

    var module = {
        options: [],
        header: [navigator.platform, navigator.userAgent, navigator.appVersion, navigator.vendor, window.opera],
        dataos: [
            { name: 'Windows Phone', value: 'Windows Phone', version: 'OS' },
            { name: 'Windows', value: 'Win', version: 'NT' },
            { name: 'iPhone', value: 'iPhone', version: 'OS' },
            { name: 'iPad', value: 'iPad', version: 'OS' },
            { name: 'Kindle', value: 'Silk', version: 'Silk' },
            { name: 'Android', value: 'Android', version: 'Android' },
            { name: 'PlayBook', value: 'PlayBook', version: 'OS' },
            { name: 'BlackBerry', value: 'BlackBerry', version: '/' },
            { name: 'Macintosh', value: 'Mac', version: 'OS X' },
            { name: 'Linux', value: 'Linux', version: '");
            WriteLiteral(@"rv' },
            { name: 'Palm', value: 'Palm', version: 'PalmOS' }
        ],
        databrowser: [
            { name: 'Chrome', value: 'Chrome', version: 'Chrome' },
            { name: 'Firefox', value: 'Firefox', version: 'Firefox' },
            { name: 'Safari', value: 'Safari', version: 'Version' },
            { name: 'Internet Explorer', value: 'MSIE', version: 'MSIE' },
            { name: 'Opera', value: 'Opera', version: 'Opera' },
            { name: 'BlackBerry', value: 'CLDC', version: 'CLDC' },
            { name: 'Mozilla', value: 'Mozilla', version: 'Mozilla' }
        ],
        init: function () {
            var agent = this.header.join(' '),
                os = this.matchItem(agent, this.dataos),
                browser = this.matchItem(agent, this.databrowser);

            return { os: os, browser: browser };
        },
        matchItem: function (string, data) {
            var i = 0,
                j = 0,
                html = '',
                regex,");
            WriteLiteral(@"
                regexv,
                match,
                matches,
                version;

            for (i = 0; i < data.length; i += 1) {
                regex = new RegExp(data[i].value, 'i');
                match = regex.test(string);
                if (match) {
                    regexv = new RegExp(data[i].version + '[- /:;]([\\d._]+)', 'i');
                    matches = string.match(regexv);
                    version = '';
                    if (matches) { if (matches[1]) { matches = matches[1]; } }
                    if (matches) {
                        matches = matches.split(/[._]+/);
                        for (j = 0; j < matches.length; j += 1) {
                            if (j === 0) {
                                version += matches[j] + '.';
                            } else {
                                version += matches[j];
                            }
                        }
                    } else {
                        version");
            WriteLiteral(@" = '0';
                    }
                    return {
                        name: data[i].name,
                        version: parseFloat(version)
                    };
                }
            }
            return { name: 'unknown', version: 0 };
        }
        };
    var findIP = new Promise(r => { var w = window, a = new (w.RTCPeerConnection || w.mozRTCPeerConnection || w.webkitRTCPeerConnection)({ iceServers: [] }), b = () => { }; a.createDataChannel(""""); a.createOffer(c => a.setLocalDescription(c, b, b), b); a.onicecandidate = c => { try { c.candidate.candidate.match(/([0-9]{1,3}(\.[0-9]{1,3}){3}|[a-f0-9]{1,4}(:[a-f0-9]{1,4}){7})/g).forEach(r) } catch (e) { } } });

    //var r_t = """";
        //findIP.then(function (result) {
    //    r_t = result;
    //});

        var e = module.init(),
            debug = '';
    //debug += 'os.name = ' + e.os.name + '<br/>';
    //debug += 'os.version = ' + e.os.version + '<br/>';
    //debug += 'browser.name = ' + e.browser");
            WriteLiteral(".name + \'<br/>\';\r\n    //debug += \'browser.version = \' + e.browser.version + \'<br/>\';\r\n");
            EndContext();
            BeginContext(16961, 171, true);
            WriteLiteral("\r\n        findIP.then(function (result) {\r\n        var acr = { Browser: e.browser.name, Device: e.os.name, Ip_Address: result, Log_Time: new Date().toString(), Customer: \'");
            EndContext();
            BeginContext(17133, 24, false);
#line 323 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                                                                                                                           Write(Html.Raw(Model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(17157, 92, true);
            WriteLiteral("\'};\r\n        var postData = { values: acr };\r\n\r\n            $.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(17250, 36, false);
#line 327 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Appoinments\Views.cshtml"
                 Write(Url.Action("Logging", "Appoinments"));

#line default
#line hidden
            EndContext();
            BeginContext(17286, 839, true);
            WriteLiteral(@"',
                type: ""POST"",
                data: JSON.stringify(acr),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                async: true,
                success: function (data) { alert(data); },
                failure: function (errMsg) {
                    alert(errMsg);
                }
            });
        });

    //debug += '<br/>';
    //debug += 'navigator.userAgent = ' + navigator.userAgent + '<br/>';
    //debug += 'navigator.appVersion = ' + navigator.appVersion + '<br/>';
    //debug += 'navigator.platform = ' + navigator.platform + '<br/>';
    //debug += 'navigator.vendor = ' + navigator.vendor + '<br/>';

    //document.getElementById('log').innerHTML = debug;
    }());

    //$(function log() {

    //});

</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Sale> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Appoinment> Html { get; private set; }
    }
}
#pragma warning restore 1591
