#pragma checksum "D:\school\Semester 3\WDPR\PROJ\src\Webdevelopment-Project\Views\Home\Sara.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e011fd1066bccd6b09a50591bc1337b9cb7490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sara), @"mvc.1.0.view", @"/Views/Home/Sara.cshtml")]
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
#line 1 "D:\school\Semester 3\WDPR\PROJ\src\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\school\Semester 3\WDPR\PROJ\src\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\school\Semester 3\WDPR\PROJ\src\Webdevelopment-Project\Views\_ViewImports.cshtml"
using Webdevelopment_Project.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e011fd1066bccd6b09a50591bc1337b9cb7490", @"/Views/Home/Sara.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1c21076fb2ae2ca7aac79de85a62aca27503d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sara : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"nl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59e011fd1066bccd6b09a50591bc1337b9cb74903487", async() => {
                WriteLiteral(@"
  <title>Sara</title>
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

  <style>
    
  p {font-size: 16px;}

  .navbar{
    position: fixed;
    white-space: normal;
    text-align: center;
    word-break: break-all;
    display: flex!important;
  }

  .bg-1 { 
    background-color: #474e5d; 
    color: #ffffff;
    border: 3px solid #2c2c2c;
    border-radius: 3px;
  }

  .bg-2 { 
    background-color: #fff; 
    color: #555555;
    border: 3px solid #2c2c2c;
    border-radius: 3px;
  }

  .bg-3 { 
    background-color: orangered; 
    color: #fff;
    border: 3px solid #2c2c2c;
    border-radius: 3px;
  }

  .bg-4 { 
    background-color: #2f2f2f; 
    color: #fff;
    border: 3px solid #2c2c2c;
    border-radius: 3px;
  }

  .container-fluid {
    padding-top: 70px;
    padding-bottom: 70px;
    text-align: center;
    max-width: 75%;
  }

</style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59e011fd1066bccd6b09a50591bc1337b9cb74905423", async() => {
                WriteLiteral(@"

<!-- First Container -->
<div class=""container-fluid bg-1 text-center"">
  <h1 class=""margin"">Sara de Jong</h1>
  <img src=""bird.jpg"" class=""img-responsive img-circle margin"" style=""display:inline"" alt=""Bird"" width=""350"" height=""350"">
  <p>Ik ben Sara de Jong. Ik ben geboren in 1989 in Voorburg en heb 1 Broertje. 
    Ik heb heel mijn jeugd gewoond in Pijnacker en ben daarna verhuist naar den haag. 
    Mijn interesses liggen in het helpen van jongeren. In mijn jeugd heb ik altijd mijn broertje geholpen met zijn ADHD. 
    Hij had veel moeite met zijn concentratie en hij is heel impulsief. 
    Waardoor hij vaak in de problemen kwam. Hij had moeite met zich aanpassen en zo had hij een lastige jeugd. 
    Ik zou graag meer kinderen zoals hem begeleiden en helpen! </p>
</div>

<!-- Second Container -->
<div class=""container-fluid bg-2 text-center"">
  <h2 class=""margin"">Wat ik gestudeerd heb</h2>
  <p>Ik heb op het Universiteit leiden gestudeerd voor Orthopedagogiek. 
    Na het halen van mijn");
                WriteLiteral(@" VWO wist ik gelijk al wat ik wilde doen en ben ik vlot door de opleiding gegaan!</p>
</div>

<!-- Third Container -->
<div class=""container-fluid bg-3 text-center"">
  <h3 class=""margin"">Nu over jou: Heb jij misschien ADHD?</h3>
    <p>Heb je soms het gevoel dat je niet kan stilzitten? 
      Of heb je het gevoel dat er allemaal dingen in jouw hoofd afspelen en je kan niet concentreren op 1 ding? 
      Of neem je snel besluiten zonder erbij over na te denken? Dan is het mogelijk dat je ADHD hebt! </p>
</div>

<!-- Fourth Container -->
<div class=""container-fluid bg-4 text-center"">
  <h3 class=""margin"">Maar wat nu?</h3>
    <p>
    Wij zullen eerst testen en uitzoeken of je echt ADHD hebt! Als dit klopt, dan zullen we samen kijken naar hoe jij ermee omgaat. 
    Ik zal je ook helpen en begeleiden met hoe je met jouw ADHD omgaat!
    Er zijn verschillenden dingen die we kunnen doen om je er mee te helpen. 
    Je kan ook veel uit je ADHD halen en daar zullen we ook aandacht aanbesteden. Samen");
                WriteLiteral(@" zullen we zorgen dat jij jouw ADHD kan beheersen. 
    Als je het nog niet zeker weet of je wilt meer informatie, kan je mij altijd mailen of bellen. 
    We plannen dan een intakegesprek in en dan kijken we of het klikt. Daarna kan je altijd nog jouw keuze veranderen!   
    </p>
</div>

");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
