#pragma checksum "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Sales\Image.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbbb1dbf402899d88b70075be0a9cace1286dbb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Image), @"mvc.1.0.view", @"/Views/Sales/Image.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sales/Image.cshtml", typeof(AspNetCore.Views_Sales_Image))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbbb1dbf402899d88b70075be0a9cace1286dbb9", @"/Views/Sales/Image.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a961fb0ce4f853b3e2c4fa2992c1d9302b2824bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Image : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookingForm.Models.Sale>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("portrait"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("inputFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "portrait", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 109, true);
            WriteLiteral("\r\n<div style=\"display:block; height:235px;width:235px;border-radius:50%\" class=\"polaroid\">\r\n    <img id=\"img\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 141, "", 201, 1);
#line 4 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Sales\Image.cshtml"
WriteAttributeValue("", 146, Url.Action("GetPhoto", "Sales", new { id = Model.Id }), 146, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 152, true);
            WriteLiteral(" style=\"width:235px;height:235px;border-radius:50%;transition: .5s ease;backface-visibility: hidden; border:0\" />\r\n        <div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(353, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c92de9e8f7034db1bebeb5bbfc03fc94", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 6 "C:\Users\trinh\source\repos\annhome-booking-master\BookingForm\Views\Sales\Image.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Portrait);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(441, 2411, true);
            WriteLiteral(@"
    <label class=""photo"" style=""display:block; margin-top:50px;"" for=""portrait"">Photo</label>
</div>
    </div>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script>
    function readURL(input) {

        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#img').attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[0]);
        }
    }

    $(""#portrait"").change(function () {
        readURL(this);
    });
</script>

<style>
    .inputFile {
        width: 0.1px;
        height: 0.1px;
        opacity: 0;
        overflow: hidden;
        position: absolute;
        z-index: -1;
    }

    .photo {
        transition: .5s ease;
        opacity: 0;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        -ms-transform: translate(-50%, -50%)
 ");
            WriteLiteral(@"   }
    .polaroid:hover .photo {
        opacity:1;
    }
    div.polaroid {
        border-radius:50%;
        width: 200px;
        height:200px;
        background-color: white;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
        margin-bottom: 25px;
    }
    div.container {
        text-align: center;
        padding: 10px 20px;

    }
    label.photo {
       
        background-color: transparent !important;
        color: rgb(22, 185, 123) !important;
        cursor:pointer;
    }

        label.photo:hover {
            opacity:1;
        }

    #img:hover {
        opacity: 0.3;
    }

    #img:hover label.photo {
        opacity: 1;
    }

     #img:hover .middle {
        opacity: 1;
     }

        .inputFile + label {
            font-size: 1.25em;
            font-weight: 700;
            color: #4CAF50;
            background-color: white;
            display: inline-block;
        }

            .inputf");
            WriteLiteral(@"ile:focus + label,
            .inputfile + label:hover {
                background-color: white;
            }

        .inputfile + label {
            cursor: pointer; /* ""hand"" cursor */
        }

        .inputfile:focus + label {
            outline: 1px dotted #000;
            outline: -webkit-focus-ring-color auto 5px;
        }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookingForm.Models.Sale> Html { get; private set; }
    }
}
#pragma warning restore 1591
