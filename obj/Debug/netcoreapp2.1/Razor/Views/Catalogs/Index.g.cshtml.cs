#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad9fb025a1627879bc14e7cdf0bc7a064713abd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Index), @"mvc.1.0.view", @"/Views/Catalogs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogs/Index.cshtml", typeof(AspNetCore.Views_Catalogs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad9fb025a1627879bc14e7cdf0bc7a064713abd", @"/Views/Catalogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Catalog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(59, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc8ac724b8a4227bcdbc70d53673724", async() => {
                BeginContext(82, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(189, 45, false);
#line 10 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LocalCode));

#line default
#line hidden
            EndContext();
            BeginContext(234, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(290, 46, false);
#line 13 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GlobalCode));

#line default
#line hidden
            EndContext();
            BeginContext(336, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(392, 41, false);
#line 16 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(433, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(489, 45, false);
#line 19 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Direction));

#line default
#line hidden
            EndContext();
            BeginContext(534, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(590, 40, false);
#line 22 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Area));

#line default
#line hidden
            EndContext();
            BeginContext(630, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(686, 45, false);
#line 25 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NOBedroom));

#line default
#line hidden
            EndContext();
            BeginContext(731, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(787, 40, false);
#line 28 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NOWC));

#line default
#line hidden
            EndContext();
            BeginContext(827, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(883, 40, false);
#line 31 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(923, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(979, 41, false);
#line 34 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Block));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1076, 40, false);
#line 37 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.View));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 91, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Ảnh</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1239, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1288, 44, false);
#line 47 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LocalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1388, 45, false);
#line 50 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GlobalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1489, 40, false);
#line 53 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1585, 44, false);
#line 56 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direction));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1685, 39, false);
#line 59 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Area));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1780, 44, false);
#line 62 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NOBedroom));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1880, 39, false);
#line 65 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NOWC));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1975, 39, false);
#line 68 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2070, 40, false);
#line 71 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Block));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2166, 39, false);
#line 74 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.View));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 78 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
                 if (item.ApartmentDetails != null)
                {

#line default
#line hidden
            BeginContext(2318, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2338, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1549a0a66dc84494ae424e35a9073f62", async() => {
                BeginContext(2403, 12, true);
                WriteLiteral("Ảnh minh họa");
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
#line 80 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
                                              WriteLiteral(item.ApartmentDetails.Id);

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
            BeginContext(2419, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 81 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
                    
                }

#line default
#line hidden
            BeginContext(2462, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2499, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Catalog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
