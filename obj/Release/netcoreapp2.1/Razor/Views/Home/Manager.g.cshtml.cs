#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34aab2d4f037a88ffb9c4fa200da580685d36c7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manager), @"mvc.1.0.view", @"/Views/Home/Manager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manager.cshtml", typeof(AspNetCore.Views_Home_Manager))]
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
#line 1 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34aab2d4f037a88ffb9c4fa200da580685d36c7b", @"/Views/Home/Manager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Management>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("new"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
  
    ViewBag.Title = "Quản lý -";

#line default
#line hidden
            BeginContext(690, 72, true);
            WriteLiteral("\r\n<h6 style=\"font-style:italic; text-align:right\">TP. Hồ Chí Minh, ngày ");
            EndContext();
            BeginContext(763, 16, false);
#line 17 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                                                 Write(DateTime.Now.Day);

#line default
#line hidden
            EndContext();
            BeginContext(779, 8, true);
            WriteLiteral("  tháng ");
            EndContext();
            BeginContext(788, 18, false);
#line 17 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                                                                          Write(DateTime.Now.Month);

#line default
#line hidden
            EndContext();
            BeginContext(806, 5, true);
            WriteLiteral(" năm ");
            EndContext();
            BeginContext(812, 17, false);
#line 17 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                                                                                                  Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(829, 15, true);
            WriteLiteral("</h6>\r\n<hr />\r\n");
            EndContext();
            BeginContext(1113, 90, true);
            WriteLiteral("<div style=\" text-align:left\">\r\n    <p style=\"display:inline-block\">Hiện trong: </p>\r\n    ");
            EndContext();
            BeginContext(1203, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f492b7e4e09f479a96bfce7d295eec83", async() => {
                BeginContext(1253, 5, true);
                WriteLiteral("Ngày ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1262, 126, true);
            WriteLiteral("\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    ");
            EndContext();
            BeginContext(1388, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee47fc6874914a0386828f4f6a292e65", async() => {
                BeginContext(1438, 4, true);
                WriteLiteral("Tuần");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1446, 126, true);
            WriteLiteral("\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    ");
            EndContext();
            BeginContext(1572, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51ac4b64b41b4230b402215a261c38a4", async() => {
                BeginContext(1622, 5, true);
                WriteLiteral("Tháng");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1631, 126, true);
            WriteLiteral("\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    ");
            EndContext();
            BeginContext(1757, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3473c5b9f7fb462cae1c1b048fe0ad3c", async() => {
                BeginContext(1807, 3, true);
                WriteLiteral("Năm");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1814, 126, true);
            WriteLiteral("\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    <span style=\"display:inline-block; width:2px;\"></span>\r\n    ");
            EndContext();
            BeginContext(1940, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f00ccedad34b799f4d4889554df2f8", async() => {
                BeginContext(1990, 6, true);
                WriteLiteral("Tất cả");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2000, 582, true);
            WriteLiteral(@"
</div>
<span style=""display:block; height:30px""></span>
<table class=""table"" >
    <thead>
        <tr>
            <th colspan=""1"" style=""text-align: center"">Sale</th>
            <th style=""text-align: center"" colspan=""6"">SL các loại (Đvị: căn)</th>
        </tr>
        <tr>
            <th style=""text-align: center"">Họ & tên</th>
            <th>Căn hộ</th>
            <th>Dinh thự</th>
            <th>BTĐL</th>
            <th>BTSL</th>
            <th>NPTM (shophouse)</th>
            <th>Kios chung cư</th>
        </tr>

    </thead>
    <tbody >
");
            EndContext();
#line 57 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
         foreach (var sale in Model.sales)
        {

#line default
#line hidden
            BeginContext(2637, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(2668, 9, false);
#line 60 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
           Write(sale.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2677, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(2721, 43, true);
            WriteLiteral("            <td style=\"text-align: center\">");
            EndContext();
            BeginContext(2765, 89, false);
#line 63 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                      Write(Model.appoinments.Where(m => m.Sale == sale).Sum(m => m.NCH1 + m.NCH2 + m.NCH3 + m.NCH21));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 50, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
            EndContext();
            BeginContext(2905, 60, false);
#line 64 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                      Write(Model.appoinments.Where(m => m.Sale == sale).Sum(m => m.NMS));

#line default
#line hidden
            EndContext();
            BeginContext(2965, 50, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
            EndContext();
            BeginContext(3016, 60, false);
#line 65 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                      Write(Model.appoinments.Where(m => m.Sale == sale).Sum(m => m.NSH));

#line default
#line hidden
            EndContext();
            BeginContext(3076, 50, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
            EndContext();
            BeginContext(3127, 61, false);
#line 66 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                      Write(Model.appoinments.Where(m => m.Sale == sale).Sum(m => m.NSH1));

#line default
#line hidden
            EndContext();
            BeginContext(3188, 50, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
            EndContext();
            BeginContext(3239, 61, false);
#line 67 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                      Write(Model.appoinments.Where(m => m.Sale == sale).Sum(m => m.NSHH));

#line default
#line hidden
            EndContext();
            BeginContext(3300, 50, true);
            WriteLiteral("</td>\r\n            <td style=\"text-align: center\">");
            EndContext();
            BeginContext(3351, 59, false);
#line 68 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
                                      Write(Model.appoinments.Where(m => m.Sale == sale).Sum(m => m.NS));

#line default
#line hidden
            EndContext();
            BeginContext(3410, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Home\Manager.cshtml"
        }

#line default
#line hidden
            BeginContext(3443, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Management> Html { get; private set; }
    }
}
#pragma warning restore 1591
