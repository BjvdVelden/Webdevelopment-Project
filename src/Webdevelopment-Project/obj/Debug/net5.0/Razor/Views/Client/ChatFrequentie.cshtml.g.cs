#pragma checksum "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ae9ebfcfd85d83ac0c22ef81277bdd266418b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ChatFrequentie), @"mvc.1.0.view", @"/Views/Client/ChatFrequentie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ae9ebfcfd85d83ac0c22ef81277bdd266418b6", @"/Views/Client/ChatFrequentie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1c21076fb2ae2ca7aac79de85a62aca27503d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_ChatFrequentie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Message>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
  
    ViewData["Title"] = "ChatFrequentie";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ae9ebfcfd85d83ac0c22ef81277bdd266418b63886", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>MyEdit</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ae9ebfcfd85d83ac0c22ef81277bdd266418b64950", async() => {
                WriteLiteral("\r\n    <div class=\"card-body\">\r\n        <div class=\"list-group\">\r\n            <h2>Chatfrequentie ");
#nullable restore
#line 18 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
                          Write(ViewData["naamClient"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <table class=\"table table-striped table-sm\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
               Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
               Write(Html.DisplayNameFor(model => model.When));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
                   Write(Html.DisplayFor(modelItem => item.When));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "c:\Users\Serdi\Desktop\Webdevelopment-Project\src\Webdevelopment-Project\Views\Client\ChatFrequentie.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
