#pragma checksum "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8803768d12176407fcbb4e4472ba6931061bc3eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moderator_Relatie), @"mvc.1.0.view", @"/Views/Moderator/Relatie.cshtml")]
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
#line 1 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8803768d12176407fcbb4e4472ba6931061bc3eb", @"/Views/Moderator/Relatie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935e09e68c2a6de61d3ce5b2c8625055345438f", @"/Views/_ViewImports.cshtml")]
    public class Views_Moderator_Relatie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Afspraak>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
  
    ViewData["Title"] = "Relaties ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
           Write(Html.DisplayNameFor(model => model.HulpverlenerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClientEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
           Write(Html.DisplayFor(modelItem => item.HulpverlenerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Moderator\Relatie.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Afspraak>> Html { get; private set; }
    }
}
#pragma warning restore 1591
