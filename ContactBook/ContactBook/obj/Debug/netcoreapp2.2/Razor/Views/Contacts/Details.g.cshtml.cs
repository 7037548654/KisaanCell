#pragma checksum "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34febd336277e1d3d2586d4921f1243d8e1576e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Details), @"mvc.1.0.view", @"/Views/Contacts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/Details.cshtml", typeof(AspNetCore.Views_Contacts_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34febd336277e1d3d2586d4921f1243d8e1576e9", @"/Views/Contacts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863c1c6c61fcc14809f49390398a68c727332d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactBook.Models.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Contact</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(209, 40, false);
#line 14 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
            EndContext();
            BeginContext(249, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(311, 36, false);
#line 17 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Item));

#line default
#line hidden
            EndContext();
            BeginContext(347, 136, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Quantity(in Kg)\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(484, 40, false);
#line 23 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(524, 132, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n           Price(in Rs)\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(657, 37, false);
#line 29 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(694, 137, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Location of Item\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(832, 40, false);
#line 35 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(872, 121, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    <input type=\"button\" title=\"Edit\" class=\"btn btn-primary\" value=\"Edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 993, "\"", 1073, 3);
            WriteAttributeValue("", 1003, "location.href=\'", 1003, 15, true);
#line 42 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
WriteAttributeValue("", 1018, Url.Action("Edit", "Contacts", new { id = Model.Id }), 1018, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 1072, "\'", 1072, 1, true);
            EndWriteAttribute();
            BeginContext(1074, 89, true);
            WriteLiteral(" />\r\n    <input type=\"button\" class=\"btn btn-primary\" title=\"Create\" value=\"Back To List\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1163, "\"", 1221, 3);
            WriteAttributeValue("", 1173, "location.href=\'", 1173, 15, true);
#line 43 "C:\Users\admin\source\repos\ContactBook\ContactBook\Views\Contacts\Details.cshtml"
WriteAttributeValue("", 1188, Url.Action("Index", "Contacts"), 1188, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1220, "\'", 1220, 1, true);
            EndWriteAttribute();
            BeginContext(1222, 13, true);
            WriteLiteral(" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactBook.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
