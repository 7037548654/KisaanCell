#pragma checksum "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97c1f2f4000822b21320a1c04de9a281c2c8f2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buyer_Index), @"mvc.1.0.view", @"/Views/Buyer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Buyer/Index.cshtml", typeof(AspNetCore.Views_Buyer_Index))]
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
#line 1 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\_ViewImports.cshtml"
using ContactBook;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\_ViewImports.cshtml"
using ContactBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97c1f2f4000822b21320a1c04de9a281c2c8f2c", @"/Views/Buyer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863c1c6c61fcc14809f49390398a68c727332d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Buyer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactBook.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Buyer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97c1f2f4000822b21320a1c04de9a281c2c8f2c4011", async() => {
                BeginContext(137, 180, true);
                WriteLiteral("\r\n    <p align=\"center\">\r\n        <strong>Item:</strong> <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" class=\"btn btn-primary\" value=\"Search\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(324, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 40, false);
#line 15 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
            EndContext();
            BeginContext(451, 223, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Quantity(in kg)\r\n            </th>\r\n            <th>\r\n                Price(in Rs)\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(723, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(784, 39, false);
#line 31 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item));

#line default
#line hidden
            EndContext();
            BeginContext(823, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(891, 43, false);
#line 34 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(934, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1002, 40, false);
#line 37 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(1236, 96, true);
            WriteLiteral("                    <input type=\"button\" class=\"btn btn-primary\" title=\"Details\" value=\"Details\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1332, "\"", 1411, 3);
            WriteAttributeValue("", 1342, "location.href=\'", 1342, 15, true);
#line 42 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
WriteAttributeValue("", 1357, Url.Action("Details", "Buyer", new { id = item.Id }), 1357, 53, false);

#line default
#line hidden
            WriteAttributeValue("", 1410, "\'", 1410, 1, true);
            EndWriteAttribute();
            BeginContext(1412, 47, true);
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 45 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Buyer\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1470, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactBook.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591