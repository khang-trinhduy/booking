#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2189991783d7e053b348f26611aba4178dd99d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Section), @"mvc.1.0.view", @"/Views/Catalogs/Section.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogs/Section.cshtml", typeof(AspNetCore.Views_Catalogs_Section))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2189991783d7e053b348f26611aba4178dd99d5", @"/Views/Catalogs/Section.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogs_Section : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingForm.Models.Section>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sample", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBlocks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
  
    Layout = "~/Views/Catalogs/DumbLayout.cshtml";
    ViewData["title"] = "Sản phẩm";
    string path = "~images/catalog/section/";

#line default
#line hidden
            BeginContext(191, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(278, 40, false);
#line 12 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(318, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(374, 40, false);
#line 15 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 45, false);
#line 18 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
            EndContext();
            BeginContext(515, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(571, 44, false);
#line 21 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(615, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(671, 42, false);
#line 24 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayNameFor(model => model.Blocks));

#line default
#line hidden
            EndContext();
            BeginContext(713, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(808, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(857, 39, false);
#line 32 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(896, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(952, 39, false);
#line 35 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
           Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(991, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1046, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5760d89e8c445a7a27a061981259fbf", async() => {
                BeginContext(1101, 3, true);
                WriteLiteral("Xem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-str", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
                                          WriteLiteral(item.ImagePath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["str"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-str", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["str"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1163, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57a6ea2b2f4c4a9f9a81fb9359d7b84a", async() => {
                BeginContext(1217, 3, true);
                WriteLiteral("Xem");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-str", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
                                          WriteLiteral(item.Location);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["str"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-str", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["str"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1224, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 44 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
                 if (item.Blocks != null && item.Blocks.Count > 0)
                {

#line default
#line hidden
            BeginContext(1350, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1370, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf511a79a6ed48e0a6e0966c6381962b", async() => {
                BeginContext(1420, 14, true);
                WriteLiteral("Danh sách khối");
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
#line 46 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
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
            BeginContext(1438, 18, true);
            WriteLiteral("                \r\n");
            EndContext();
#line 47 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
                    
                }

#line default
#line hidden
            BeginContext(1497, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Catalogs\Section.cshtml"
}

#line default
#line hidden
            BeginContext(1534, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingForm.Models.Section>> Html { get; private set; }
    }
}
#pragma warning restore 1591
