#pragma checksum "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\ModeratorDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d672e7cb6ca27e9731b3fcfb3da787f266311c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ModeratorDashboard_Index), @"mvc.1.0.view", @"/Views/ModeratorDashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d672e7cb6ca27e9731b3fcfb3da787f266311c", @"/Views/ModeratorDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935e09e68c2a6de61d3ce5b2c8625055345438f", @"/Views/_ViewImports.cshtml")]
    public class Views_ModeratorDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Serdi\Desktop\Webdevelopment-Project\Views\ModeratorDashboard\Index.cshtml"
  
  ViewData["Title"] = "Hulpverlener Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section>
  <h3 class=""text-center"">Welkom op het moderator dashboard!</h3>
  <div class=""container-fluid"">
    <div class=""row"">
      <div class=""col-md"">
        <div class=""col-md-12 questionBox"">
          <p>Klik op de onderstaande knop om een overzicht van clienten en Hulpverleners te zien!</p> <br>
          <a href=""/ModeratorDashboard/ClientEnHulpverlener""><button aria-label=""Klik hier om naar het overzicht van clienten en Hulpverleners te gaan"">Ga naar het overzicht</button></a>
        </div>
</section>
<br>
<section>
  <div class=""container-fluid"">
    <div class=""row"">
      <div class=""col-md"">
        <div class=""col-md-12 questionBox"">
          <p>Klik op de onderstaande knop om een overzicht van de behandelingen te zien!</p> <br>
          <a href=""/ModeratorDashboard/BehandelingsOverzicht""><button aria-label=""Klik hier om naar het overzicht met behandelingen te gaan"">Ga naar het overzicht</button></a>
        </div>
</section>
");
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
