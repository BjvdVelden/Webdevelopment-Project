#pragma checksum "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c406775f421c574387d661abcd2162d0feca77a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c406775f421c574387d661abcd2162d0feca77a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1935e09e68c2a6de61d3ce5b2c8625055345438f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Yeb93\OneDrive\Documenten\GitHub\Webdevelopment-Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <link href=""../../../../dist/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Custom styles for this template -->
    <link href=""carousel.css"" rel=""stylesheet"">

      <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
          <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
          <li data-target=""#myCarousel"" data-slide-to=""1""></li>
          <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
          <div class=""carousel-item active"">
            <img class=""first-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=="" alt=""First slide"">
            <div class=""container"">
              <div class=""carousel-caption text-left"">
                <h1>Example headline.</h1>
                <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id d");
            WriteLiteral(@"olor id nibh ultricies vehicula ut id elit.</p>
                <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
              </div>
            </div>
          </div>
          <div class=""carousel-item"">
            <img class=""second-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw=="" alt=""Second slide"">
            <div class=""container"">
              <div class=""carousel-caption"">
                <h1>Another example headline.</h1>
                <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
              </div>
            </div>
          </div>
          <div class=""carousel-item"">
            <img class=""third-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABA");
            WriteLiteral(@"AEAAAICRAEAOw=="" alt=""Third slide"">
            <div class=""container"">
              <div class=""carousel-caption text-right"">
                <h1>One more for good measure.</h1>
                <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
              </div>
            </div>
          </div>
        </div>
        <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
          <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
          <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
          <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
          <span class=""sr-only"">Next</span>
        </a>
      ");
            WriteLiteral(@"</div>

        <hr class=""featurette-divider"">

        <div class=""row featurette"">
          <div class=""col-md-7"">
            <h2 class=""featurette-heading"">First featurette heading. <span class=""text-muted"">It'll blow your mind.</span></h2>
            <p class=""lead"">Donec ullamcorper nulla non metus auctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
          </div>
          <div class=""col-md-5"">
            <img class=""featurette-image img-fluid mx-auto"" data-src=""holder.js/500x500/auto"" alt=""Generic placeholder image"">
          </div>
        </div>

        <hr class=""featurette-divider"">

        <div class=""row featurette"">
          <div class=""col-md-7 order-md-2"">
            <h2 class=""featurette-heading"">Oh yeah, it's that good. <span class=""text-muted"">See for yourself.</span></h2>
            <p class=""lead"">Donec ullamcorper nulla non metus au");
            WriteLiteral(@"ctor fringilla. Vestibulum id ligula porta felis euismod semper. Praesent commodo cursus magna, vel scelerisque nisl consectetur. Fusce dapibus, tellus ac cursus commodo.</p>
          </div>
          <div class=""col-md-5 order-md-1"">
            <img class=""featurette-image img-fluid mx-auto"" data-src=""holder.js/500x500/auto"" alt=""Generic placeholder image"">
          </div>
        </div>

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
