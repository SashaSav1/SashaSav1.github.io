#pragma checksum "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae288975314b2759fc28c795f35f8bec527735ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Search), @"mvc.1.0.view", @"/Views/Products/Search.cshtml")]
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
#nullable restore
#line 1 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\_ViewImports.cshtml"
using GODDAMN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\_ViewImports.cshtml"
using GODDAMN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae288975314b2759fc28c795f35f8bec527735ad", @"/Views/Products/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6c1b122949f93e7669a6b69af4440ac387bd6e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GODDAMN.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Поиск по ");
#nullable restore
#line 3 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
                              Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br>\r\n    <hr color=black>\r\n\r\n");
#nullable restore
#line 7 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
 foreach (var product in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"shadow-lg\">\r\n    <div class=\"container\">\r\n    <div>\r\n                    <span style=\"padding: 0px 20px;\">&nbsp;</span>\r\n\r\n        <h2>");
#nullable restore
#line 13 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <span style=\"padding: 0px 20px;\">&nbsp;</span>\r\n\r\n        </div>\r\n        <div class=\"scale1\">\r\n            <img class=\"center_\"");
            BeginWriteAttribute("src", " src=\"", 517, "\"", 535, 1);
#nullable restore
#line 18 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
WriteAttributeValue("", 523, product.Img, 523, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""610"" height=""620"" />
        </div>
        <div>
            <span style=""padding: 0px 5px;"">&nbsp;</span>
            <span style=""padding: 0px 5px;"">&nbsp;</span>
            <span style=""padding: 0px 5px;"">&nbsp;</span>
        </div>
        <div class=""mytextind1"">
            <div class=""shadow-sm"">
            <span");
            BeginWriteAttribute("class", " class=\"", 878, "\"", 886, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
                      Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div class=\"mytextind\">\r\n            <span>Размер: ");
#nullable restore
#line 31 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
                     Write(product.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span style=\"padding: 0px 5px;\">&nbsp;</span>\r\n\r\n            <span>Цена: ");
#nullable restore
#line 34 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span style=\"padding: 0px 5px;\">&nbsp;</span>\r\n        </div>\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae288975314b2759fc28c795f35f8bec527735ad7139", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"a\"");
                BeginWriteAttribute("value", " value=\"", 1334, "\"", 1361, 1);
#nullable restore
#line 40 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
WriteAttributeValue("", 1342, User.Identity.Name, 1342, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"b\"");
                BeginWriteAttribute("value", " value=\"", 1408, "\"", 1427, 1);
#nullable restore
#line 41 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"
WriteAttributeValue("", 1416, product.Id, 1416, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"c\" value=\"About\" />\r\n            <input type=\"submit\" class=\"floating-button\" value=\"Добавить\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n        <span style=\"padding: 0px 20px;\">&nbsp;</span>\r\n");
#nullable restore
#line 48 "D:\прога уп(asp net core)\GODDAMN\GODDAMN\Views\Products\Search.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GODDAMN.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
