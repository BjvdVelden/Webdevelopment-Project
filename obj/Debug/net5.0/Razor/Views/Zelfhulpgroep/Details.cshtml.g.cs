#pragma checksum "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea831dd2bcaa755e25b14a3d0fa687bec4a6f627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zelfhulpgroep_Details), @"mvc.1.0.view", @"/Views/Zelfhulpgroep/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea831dd2bcaa755e25b14a3d0fa687bec4a6f627", @"/Views/Zelfhulpgroep/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935e09e68c2a6de61d3ce5b2c8625055345438f", @"/Views/_ViewImports.cshtml")]
    public class Views_Zelfhulpgroep_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webdevelopment_Project.Models.Zelfhulpgroep>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Zelfhulpgroep/Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Onderwerp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayFor(model => model.Onderwerp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinimaleLeeftijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinimaleLeeftijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaximaleLeeftijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaximaleLeeftijd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Beheerder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
       Write(Html.DisplayFor(model => model.Beheerder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n\r\n<div>\r\n");
#nullable restore
#line 42 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
     if (!(bool)ViewData["beheerder"])
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
     if (!(bool)ViewData["aanmelden"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea831dd2bcaa755e25b14a3d0fa687bec4a6f6278613", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1278, "\"", 1297, 1);
#nullable restore
#line 47 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
WriteAttributeValue("", 1286, Model.Naam, 1286, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"aanmelden\" id=\"aanmelden\" value=\"true\">\r\n        <input type=\"submit\" value=\"aanmelden\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
    }else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea831dd2bcaa755e25b14a3d0fa687bec4a6f62710967", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1569, "\"", 1588, 1);
#nullable restore
#line 54 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
WriteAttributeValue("", 1577, Model.Naam, 1577, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"aanmelden\" id=\"aanmelden\" value=\"false\">\r\n        <input type=\"submit\" value=\"afmelden\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
     if ((bool)ViewData["rechten"]){

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea831dd2bcaa755e25b14a3d0fa687bec4a6f62713760", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
                           WriteLiteral(Model.Naam);

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
#nullable restore
#line 62 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Zelfhulpgroep\Details.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea831dd2bcaa755e25b14a3d0fa687bec4a6f62716169", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webdevelopment_Project.Models.Zelfhulpgroep> Html { get; private set; }
    }
}
#pragma warning restore 1591
