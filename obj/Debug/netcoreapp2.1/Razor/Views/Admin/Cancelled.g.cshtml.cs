#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385299e08605be663315b2df3a73ce6c34651c0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Cancelled), @"mvc.1.0.view", @"/Views/Admin/Cancelled.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Cancelled.cshtml", typeof(AspNetCore.Views_Admin_Cancelled))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"385299e08605be663315b2df3a73ce6c34651c0b", @"/Views/Admin/Cancelled.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Cancelled : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Appoinment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Withdraw", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 561, true);
            WriteLiteral(@"<table style=""border:solid #ddd 1px;white-space:nowrap; overflow:hidden"" class=""table"">
    <colgroup>
        <col span=""11"">
    </colgroup>
    <thead>
        <tr style=""background-color:#3fa5ea; color:#ffffff"">
            <th rowspan=""2"" style=""vertical-align:middle; text-align:center""> STT </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Họ tên KH
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                TT Sale
            </th>
");
            EndContext();
            BeginContext(668, 1884, true);
            WriteLiteral(@"            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Số HĐ
            </th>
            <th colspan=""6"">
                STT từng loại
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Tiền đặt chỗ
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                TG đặt chỗ
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Đã nộp
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Thời gian nộp
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Ngày hoàn tiền
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Số tiền
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; ");
            WriteLiteral(@"text-align: center"">
                Hình thức
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Mã phiếu thu (nếu có)
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">
                Ghi chú
            </th>
            <th rowspan=""2"" style=""vertical-align:middle; text-align: center"">Thao tác</th>
        </tr>
        <tr style=""background-color:#1f96e7; color:#ffffff"">
            <th>CH</th>
            <th>
                DT
            </th>
            <th>
                BTĐL
            </th>
            <th>
                BTSL
            </th>
            <th>
                NPTM
            </th>
            <th>
                Kios
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 73 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           int count = 1;

#line default
#line hidden
            BeginContext(2580, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 74 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
         foreach (var item in Model)
        {
            var statusClass = "Yellow";
            if (item.IsActive == false)
            {
                statusClass = "White";
            }
            else if (item.Confirm == true)
            {
                statusClass = "Green";
            }


#line default
#line hidden
            BeginContext(2897, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2908, "\"", 2928, 1);
#line 86 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
WriteAttributeValue("", 2916, statusClass, 2916, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2929, 46, true);
            WriteLiteral(">\r\n            <td style=\"white-space:nowrap\">");
            EndContext();
            BeginContext(2976, 5, false);
#line 87 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                      Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(2981, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 88 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
               count++; 

#line default
#line hidden
            BeginContext(3015, 79, true);
            WriteLiteral("            <td style=\"white-space: nowrap; text-align:left\">\r\n                ");
            EndContext();
            BeginContext(3095, 43, false);
#line 90 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3194, 45, false);
#line 93 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sale.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3239, 20, true);
            WriteLiteral(" -\r\n                ");
            EndContext();
            BeginContext(3260, 46, false);
#line 94 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.SaleDetails));

#line default
#line hidden
            EndContext();
            BeginContext(3306, 57, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3364, 43, false);
#line 98 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contract));

#line default
#line hidden
            EndContext();
            BeginContext(3407, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 103 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
              
                string fs = "";
                if (item.NCH1 > 0 || item.NCH2 > 0 || item.NCH3 > 0 || item.NCH21 > 0)
                {
                    //fs += "<li>Căn hộ: " + Model.appoinment.ph + "</li>";
                    int n = item.NCH1 + item.NCH2 + item.NCH3 + item.NCH21;
                    switch (n)
                    {
                        case 1:
                            fs += "<td>" + item.ph + "</td>";
                            break;
                        case 2:
                            fs += "<td>" + Convert.ToString(item.ph - 1) + " & " + item.ph + "</td>";
                            break;
                        default:
                            fs += "<td>" + Convert.ToString(item.ph - n + 1) + " đến " + item.ph + "</td>";
                            break;

                    }
                }
                else
                {
                    fs += "<td></td>";
                }
                if (item.NMS > 0)
                {
                    //fs += "<li>Biệt thự: " + Model.appoinment.pms + "</li>";
                    switch (item.NMS)
                    {
                        case 1:
                            fs += "<td>" + item.pms + "</td>";
                            break;
                        case 2:
                            fs += "<td>" + Convert.ToString(item.pms - 1) + " & " + item.pms + "</td>";
                            break;
                        default:
                            fs += "<td>" + Convert.ToString(item.pms - item.pms + 1) + " đến " + item.pms + "</td>";
                            break;

                    }
                }
                else
                {
                    fs += "<td></td>";
                }
                if (item.NSH > 0)
                {
                    //fs += "<li>Nhà phố: " + Model.appoinment.psh + "</li>";
                    switch (item.NSH)
                    {
                        case 1:
                            fs += "<td>" + item.psh + "</p>";
                            break;
                        case 2:
                            fs += "<td>" + Convert.ToString(item.psh - 1) + " & " + item.psh + "</p>";
                            break;
                        default:
                            fs += "<td>" + Convert.ToString(item.psh - item.NSH + 1) + " đến " + item.psh + "</td>";
                            break;

                    }
                }
                else
                {
                    fs += "<td></td>";
                }
                if (item.NSH1 > 0)
                {
                    //fs += "<li>Nhà phố: " + Model.appoinment.psh + "</li>";
                    switch (item.NSH1)
                    {
                        case 1:
                            fs += "<td>" + item.psh1 + "</p>";
                            break;
                        case 2:
                            fs += "<td>" + Convert.ToString(item.psh1 - 1) + " & " + item.psh1 + "</p>";
                            break;
                        default:
                            fs += "<td>" + Convert.ToString(item.psh1 - item.NSH1 + 1) + " đến " + item.psh1 + "</td>";
                            break;

                    }
                }
                else
                {
                    fs += "<td></td>";
                }
                if (item.NSHH > 0)
                {
                    //fs += "<li>Shophouse: " + Model.appoinment.pshh + "</li>";
                    switch (item.NSHH)
                    {
                        case 1:
                            fs += "<td>" + item.pshh + "</td>";
                            break;
                        case 2:
                            fs += "<td>" + Convert.ToString(item.pshh - 1) + " & " + item.pshh + "</td>";
                            break;
                        default:
                            fs += "<td>" + Convert.ToString(item.pshh - item.NSHH + 1) + " đến " + item.pshh + "</td>";
                            break;

                    }
                }
                else
                {
                    fs += "<td></td>";
                }
                if (item.NS > 0)
                {
                    //fs += "<li>Shophouse: " + Model.appoinment.pshh + "</li>";
                    switch (item.NS)
                    {
                        case 1:
                            fs += "<td>" + item.pns + "</td>";
                            break;
                        case 2:
                            fs += "<td>" + Convert.ToString(item.pns - 1) + " & " + item.pns + "</td>";
                            break;
                        default:
                            fs += "<td>" + Convert.ToString(item.pns - item.NS + 1) + " đến " + item.pns + "</td>";
                            break;

                    }
                }
                else
                {
                    fs += "<td></td>";
                }
            

#line default
#line hidden
            BeginContext(8712, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(8725, 12, false);
#line 233 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
       Write(Html.Raw(fs));

#line default
#line hidden
            EndContext();
            BeginContext(8737, 20, true);
            WriteLiteral("\r\n            <td>\r\n");
            EndContext();
            BeginContext(8820, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(8837, 35, false);
#line 236 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(String.Format("{0:N0}", item.Money));

#line default
#line hidden
            EndContext();
            BeginContext(8872, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 238 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
              
                    string day, month, year, hour, minute, second, millisecond = "";
                    try
                    {
                        DateTime d = DateTime.ParseExact(item.cTime, "ddMMyyyy HH:mm:ss.FFFFFFF",
                                         System.Globalization.CultureInfo.InvariantCulture);
                        day = Convert.ToString(d.Day);
                        month = Convert.ToString(d.Month);
                        year = Convert.ToString(d.Year);
                        hour = Convert.ToString(d.Hour);
                        minute = Convert.ToString(d.Minute);
                        second = Convert.ToString(d.Second);
                        millisecond = Convert.ToString(d.Millisecond);
                    }
                    catch (Exception)
                    {

                        day = "--";
                        month = "--";
                        year = "----";
                        hour = "--";
                        minute = "--";
                        second = "--";
                        millisecond = "-------";

                    }

#line default
#line hidden
            BeginContext(10060, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(10103, 3, false);
#line 265 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
               Write(day);

#line default
#line hidden
            EndContext();
            BeginContext(10106, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(10108, 5, false);
#line 265 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                    Write(month);

#line default
#line hidden
            EndContext();
            BeginContext(10113, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(10115, 4, false);
#line 265 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                           Write(year);

#line default
#line hidden
            EndContext();
            BeginContext(10119, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(10121, 4, false);
#line 265 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                 Write(hour);

#line default
#line hidden
            EndContext();
            BeginContext(10125, 1, true);
            WriteLiteral(":");
            EndContext();
            BeginContext(10127, 6, false);
#line 265 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                       Write(minute);

#line default
#line hidden
            EndContext();
            BeginContext(10133, 1, true);
            WriteLiteral(":");
            EndContext();
            BeginContext(10135, 6, false);
#line 265 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                               Write(second);

#line default
#line hidden
            EndContext();
            BeginContext(10141, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(10181, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(10216, 34, false);
#line 269 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(String.Format("{0:N0}", item.Cash));

#line default
#line hidden
            EndContext();
            BeginContext(10250, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 271 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
              
                    //string day, month, year, hour, minute, second, millisecond = "";
                    try
                    {
                        DateTime d = DateTime.ParseExact(item.dTime, "ddMMyyyy HH:mm:ss.FFFFFFF",
                                         System.Globalization.CultureInfo.InvariantCulture);
                        day = Convert.ToString(d.Day);
                        month = Convert.ToString(d.Month);
                        year = Convert.ToString(d.Year);
                        hour = Convert.ToString(d.Hour);
                        minute = Convert.ToString(d.Minute);
                        second = Convert.ToString(d.Second);
                        millisecond = Convert.ToString(d.Millisecond);
                    }
                    catch (Exception)
                    {

                        day = "--";
                        month = "--";
                        year = "----";
                        hour = "--";
                        minute = "--";
                        second = "--";
                        millisecond = "-------";

                    }

#line default
#line hidden
            BeginContext(11440, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(11483, 3, false);
#line 298 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
               Write(day);

#line default
#line hidden
            EndContext();
            BeginContext(11486, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(11488, 5, false);
#line 298 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                    Write(month);

#line default
#line hidden
            EndContext();
            BeginContext(11493, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(11495, 4, false);
#line 298 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                           Write(year);

#line default
#line hidden
            EndContext();
            BeginContext(11499, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(11501, 4, false);
#line 298 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                 Write(hour);

#line default
#line hidden
            EndContext();
            BeginContext(11505, 1, true);
            WriteLiteral(":");
            EndContext();
            BeginContext(11507, 6, false);
#line 298 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                       Write(minute);

#line default
#line hidden
            EndContext();
            BeginContext(11513, 1, true);
            WriteLiteral(":");
            EndContext();
            BeginContext(11515, 6, false);
#line 298 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                               Write(second);

#line default
#line hidden
            EndContext();
            BeginContext(11521, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(11561, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(11596, 39, false);
#line 302 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.WDay));

#line default
#line hidden
            EndContext();
            BeginContext(11635, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(11691, 41, false);
#line 305 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.WMoney));

#line default
#line hidden
            EndContext();
            BeginContext(11732, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(11788, 40, false);
#line 308 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.WType));

#line default
#line hidden
            EndContext();
            BeginContext(11828, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(11884, 47, false);
#line 311 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.WithdrawCode));

#line default
#line hidden
            EndContext();
            BeginContext(11931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(11987, 39, false);
#line 314 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(12026, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(12081, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07418a98d3434bfebe4edd3ccef8d2e8", async() => {
                BeginContext(12126, 3, true);
                WriteLiteral("Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 317 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
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
            BeginContext(12133, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(12444, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(12460, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6870917fdeb24e7681f523dfe87b2fe5", async() => {
                BeginContext(12509, 13, true);
                WriteLiteral("Đơn hoàn tiền");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 322 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
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
            BeginContext(12526, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(12690, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 327 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
        }

#line default
#line hidden
            BeginContext(12735, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
            EndContext();
#line 331 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
  
    //string new_money = Convert.ToString(money);
    double money = Model.Sum(m => m.Cash);
    string new_money = String.Format("{0:N0}", money);


#line default
#line hidden
            BeginContext(12921, 126, true);
            WriteLiteral("<label style=\"display:block; text-align:right;font-family:\'Times New Roman\'; font-style:italic; font-size:x-large\">Tổng tiền: ");
            EndContext();
            BeginContext(13048, 9, false);
#line 337 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                                                                                                                         Write(new_money);

#line default
#line hidden
            EndContext();
            BeginContext(13057, 202, true);
            WriteLiteral(" VNĐ</label>\r\n<label style=\"font-family:\'Times New Roman\'; font-size: x-large\">Tổng số căn: </label>\r\n<ul style=\"font-family:\'Times New Roman\'; list-style: square; font-size: x-large\">\r\n    <li>Căn hộ: ");
            EndContext();
            BeginContext(13260, 50, false);
#line 340 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
           Write(Model.Sum(m => m.NCH1 + m.NCH2 + m.NCH21 + m.NCH3));

#line default
#line hidden
            EndContext();
            BeginContext(13310, 25, true);
            WriteLiteral("</li>\r\n    <li>Biệt thự: ");
            EndContext();
            BeginContext(13336, 21, false);
#line 341 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
             Write(Model.Sum(m => m.NMS));

#line default
#line hidden
            EndContext();
            BeginContext(13357, 24, true);
            WriteLiteral("</li>\r\n    <li>Nhà phố: ");
            EndContext();
            BeginContext(13382, 21, false);
#line 342 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
            Write(Model.Sum(m => m.NSH));

#line default
#line hidden
            EndContext();
            BeginContext(13403, 35, true);
            WriteLiteral("</li>\r\n    <li>Nhà phố thương mại: ");
            EndContext();
            BeginContext(13439, 22, false);
#line 343 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                       Write(Model.Sum(m => m.NSHH));

#line default
#line hidden
            EndContext();
            BeginContext(13461, 29, true);
            WriteLiteral("</li>\r\n    <li>Shop khối đế: ");
            EndContext();
            BeginContext(13491, 20, false);
#line 344 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Admin\Cancelled.cshtml"
                 Write(Model.Sum(m => m.NS));

#line default
#line hidden
            EndContext();
            BeginContext(13511, 899, true);
            WriteLiteral(@"</li>
</ul>
<style>
    /*tr:hover {
        background-color: #ddd;
    }*/
    .Red {
        color: #ffffff;
        background-color: #f74743
    }

    .Green {
        color: #ffffff;
        background-color: #2ed75d
    }

    .Yellow {
        background-color: #f6f11d
    }

    th, td {
        border-left: 1px solid #ddd;
    }

    table, td, th {
        border: 1px solid #ddd;
        text-align: left;
    }

    table {
        border-collapse: collapse;
        width: 100%;
    }

    th, td {
        padding: 15px;
    }

    th, td {
        text-align: center;
        vertical-align: middle;
    }

    tr:hover {
        background-color: #ffffff;
        color: #1f96e7;
        cursor: pointer;
    }
</style>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Appoinment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
