#pragma checksum "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7499c005d04adc66a3315ca44a60d5d5a97f69e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignUp), @"mvc.1.0.view", @"/Views/Account/SignUp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SignUp.cshtml", typeof(AspNetCore.Views_Account_SignUp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7499c005d04adc66a3315ca44a60d5d5a97f69e8", @"/Views/Account/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863c1c6c61fcc14809f49390398a68c727332d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactBook.Models.SignUpModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "dosignup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
  
    ViewData["Title"] = "SignUp";

#line default
#line hidden
            BeginContext(81, 19, true);
            WriteLiteral("\r\n<h1>SignUp</h1>\r\n");
            EndContext();
            BeginContext(100, 561, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7499c005d04adc66a3315ca44a60d5d5a97f69e84435", async() => {
                BeginContext(106, 548, true);
                WriteLiteral(@"
<style>
    .button {
        background-color: Grey; /* Green */
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
        -webkit-transition-duration: 0.4s; /* Safari */
        transition-duration: 0.4s;
    }
    

    .button2:hover {
        box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24),0 17px 50px 0 rgba(0,0,0,0.19);
    }
</style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(663, 2519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7499c005d04adc66a3315ca44a60d5d5a97f69e86164", async() => {
                BeginContext(669, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(671, 2498, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7499c005d04adc66a3315ca44a60d5d5a97f69e86547", async() => {
                    BeginContext(724, 90, true);
                    WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td colspan=\"2\">FirstName:</td>\r\n            <td>");
                    EndContext();
                    BeginContext(815, 33, false);
#line 35 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
                    EndContext();
                    BeginContext(848, 42, true);
                    WriteLiteral("</td>\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(891, 43, false);
#line 36 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
                    EndContext();
                    BeginContext(934, 98, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td colspan=\"2\">Lastname:</td>\r\n            <td>");
                    EndContext();
                    BeginContext(1033, 32, false);
#line 41 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
                    EndContext();
                    BeginContext(1065, 42, true);
                    WriteLiteral("</td>\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(1108, 42, false);
#line 42 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
                    EndContext();
                    BeginContext(1150, 118, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">Account Type:</td>\r\n            <td>\r\n                ");
                    EndContext();
                    BeginContext(1269, 297, false);
#line 47 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.DropDownListFor(m => m.type, new List<SelectListItem>
               { new SelectListItem{Text="Buyer", Value="Buyer"},
                 new SelectListItem{Text="Seller", Value="Seller"},
                 new SelectListItem{Text="Representative", Value="Representative"}}, "Please select"));

#line default
#line hidden
                    EndContext();
                    BeginContext(1566, 56, true);
                    WriteLiteral("\r\n            </td>\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(1623, 38, false);
#line 52 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.type));

#line default
#line hidden
                    EndContext();
                    BeginContext(1661, 98, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td colspan=\"2\">Username:</td>\r\n            <td>");
                    EndContext();
                    BeginContext(1760, 32, false);
#line 57 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
                    EndContext();
                    BeginContext(1792, 44, true);
                    WriteLiteral("</td>\r\n\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(1837, 42, false);
#line 59 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
                    EndContext();
                    BeginContext(1879, 80, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">Password:</td>\r\n");
                    EndContext();
                    BeginContext(2019, 16, true);
                    WriteLiteral("            <td>");
                    EndContext();
                    BeginContext(2036, 33, false);
#line 64 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
                    EndContext();
                    BeginContext(2069, 44, true);
                    WriteLiteral("</td>\r\n\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(2114, 42, false);
#line 66 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
                    EndContext();
                    BeginContext(2156, 100, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">Full Address:</td>\r\n            <td>");
                    EndContext();
                    BeginContext(2257, 31, false);
#line 70 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.Address));

#line default
#line hidden
                    EndContext();
                    BeginContext(2288, 44, true);
                    WriteLiteral("</td>\r\n\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(2333, 41, false);
#line 72 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.Address));

#line default
#line hidden
                    EndContext();
                    BeginContext(2374, 101, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">Mobile Number:</td>\r\n            <td>");
                    EndContext();
                    BeginContext(2476, 28, false);
#line 76 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.Cell));

#line default
#line hidden
                    EndContext();
                    BeginContext(2504, 44, true);
                    WriteLiteral("</td>\r\n\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(2549, 38, false);
#line 78 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.Cell));

#line default
#line hidden
                    EndContext();
                    BeginContext(2587, 87, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td colspan=\"2\">Date Of Birth:</td>\r\n");
                    EndContext();
                    BeginContext(2729, 34, true);
                    WriteLiteral("            <td>\r\n                ");
                    EndContext();
                    BeginContext(2764, 110, false);
#line 85 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
           Write(Html.TextBoxFor(model => model.DOB,
       new { @type = "date", @Value = Model.DOB.ToString("yyyy-MM-dd") }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2874, 56, true);
                    WriteLiteral("\r\n            </td>\r\n            <td style=\"color:red;\">");
                    EndContext();
                    BeginContext(2931, 37, false);
#line 88 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Account\SignUp.cshtml"
                              Write(Html.ValidationMessageFor(m => m.DOB));

#line default
#line hidden
                    EndContext();
                    BeginContext(2968, 194, true);
                    WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <button class=\"button button2\" type=\"submit\">signup</button>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3169, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactBook.Models.SignUpModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
