#pragma checksum "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16270768239bb196f753e72ef41dd343d93c907b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moderator_Blokkeren), @"mvc.1.0.view", @"/Views/Moderator/Blokkeren.cshtml")]
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
#line 1 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16270768239bb196f753e72ef41dd343d93c907b", @"/Views/Moderator/Blokkeren.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1c21076fb2ae2ca7aac79de85a62aca27503d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Moderator_Blokkeren : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Moderator/Blokkeren"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
Write(ViewData["blockt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
  
    ViewData["Title"] = "blockeren";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>gebruikers</h1>


   


<table class=""table"">
    <thead>
        <tr>
            <th>
                voornaam
            </th>
            
            <th>
                email
            </th>
            <th>
                deblockeren/blockeren
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
 foreach (var user in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
           Write(user.Voornaam);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n               \r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            \r\n            <td>\r\n            \r\n");
#nullable restore
#line 40 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
                 if (((IEnumerable<ApplicationUser>)ViewData["blockt"]).Any(item => item.Id == user.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16270768239bb196f753e72ef41dd343d93c907b6090", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"id\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 926, "\"", 942, 1);
#nullable restore
#line 43 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
WriteAttributeValue("", 934, user.Id, 934, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"submit\" value=\"deblokkeren\">\r\n                    ");
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
#line 46 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16270768239bb196f753e72ef41dd343d93c907b8364", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"id\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1208, 1);
#nullable restore
#line 48 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
WriteAttributeValue("", 1200, user.Id, 1200, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"submit\" value=\"blokkeren\">\r\n                    ");
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
#line 51 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
                                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\Moderator\Blokkeren.cshtml"
}                

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
