#pragma checksum "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08287225001882ecf23c30c544b55509a1fb3c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hulpverlener_Details), @"mvc.1.0.view", @"/Views/Hulpverlener/Details.cshtml")]
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
#line 1 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08287225001882ecf23c30c544b55509a1fb3c0", @"/Views/Hulpverlener/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1c21076fb2ae2ca7aac79de85a62aca27503d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Hulpverlener_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webdevelopment_Project.Models.Hulpverlener>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Hulpverlener</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClientID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.Voornaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.Achternaam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GeboorteDatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.GeboorteDatum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Postcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.Postcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Huisnummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.Huisnummer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VoogdEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.VoogdEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HulpverlenerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.HulpverlenerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.NormalizedEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.SecurityStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumberConfirmed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.TwoFactorEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.LockoutEnabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccessFailedCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08287225001882ecf23c30c544b55509a1fb3c020002", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 149 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Hulpverlener\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08287225001882ecf23c30c544b55509a1fb3c022173", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webdevelopment_Project.Models.Hulpverlener> Html { get; private set; }
    }
}
#pragma warning restore 1591
