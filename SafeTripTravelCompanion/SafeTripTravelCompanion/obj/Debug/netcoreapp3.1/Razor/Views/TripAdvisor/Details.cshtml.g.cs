#pragma checksum "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e1cc64ecd2e0576cde4c012b01edd190fb60bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TripAdvisor_Details), @"mvc.1.0.view", @"/Views/TripAdvisor/Details.cshtml")]
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
#line 1 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\_ViewImports.cshtml"
using SafeTripTravelCompanion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\_ViewImports.cshtml"
using SafeTripTravelCompanion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e1cc64ecd2e0576cde4c012b01edd190fb60bb", @"/Views/TripAdvisor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cecd800cf03a59c50530dce33c9a5dfcca1d9c", @"/Views/_ViewImports.cshtml")]
    public class Views_TripAdvisor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SafeTripTravelCompanion.Models.TripAdvisor.Attraction.LocationDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            Name\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 16 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Location\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 22 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.location_string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Address\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 28 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            User Experience Rating\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 34 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Rank\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 40 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.ranking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Description\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 46 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Phone Number\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 52 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Website URL\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 58 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
       Write(Html.DisplayFor(model => model.website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Photo\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n");
#nullable restore
#line 64 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
              
                var img = Model.photo.images.original;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=", 1751, "", 1764, 1);
#nullable restore
#line 67 "C:\Users\christopherke\source\repos\GCFinalProject\SafeTripTravelCompanion\SafeTripTravelCompanion\Views\TripAdvisor\Details.cshtml"
WriteAttributeValue("", 1756, img.url, 1756, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"300\" />\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SafeTripTravelCompanion.Models.TripAdvisor.Attraction.LocationDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
