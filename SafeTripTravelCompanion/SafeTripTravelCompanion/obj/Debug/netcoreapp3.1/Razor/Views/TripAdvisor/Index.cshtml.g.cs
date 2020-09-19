#pragma checksum "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46843abb5eb9ed531cb933c026f6fad07115ceb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TripAdvisor_Index), @"mvc.1.0.view", @"/Views/TripAdvisor/Index.cshtml")]
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
#line 1 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/_ViewImports.cshtml"
using SafeTripTravelCompanion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/_ViewImports.cshtml"
using SafeTripTravelCompanion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46843abb5eb9ed531cb933c026f6fad07115ceb6", @"/Views/TripAdvisor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a96582b6b9fe52ffc5b353140591b724ef93eb", @"/Views/_ViewImports.cshtml")]
    public class Views_TripAdvisor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SafeTripTravelCompanion.Models.TripAdvisor.Location.DataLocation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BucketList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n\n<h1>Attractions for \"");
#nullable restore
#line 8 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
                Write(ViewBag.Search);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                COVID Danger Rate:
            </th>
            <th>
                Name:
            </th>
            <th>
                Location:
            </th>
            <th>
                Photo:
            </th>
");
#nullable restore
#line 26 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
             if (SignInManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\n                    Add:\n                </th>\n");
#nullable restore
#line 31 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 35 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
         foreach (var result in Model)
        {
            if (result.result_type == "things_to_do" && result.result_object.address_obj.country == "United States")
            {
                var item = result.result_object;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n\n            <td>\n                ");
#nullable restore
#line 44 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
           Write(Html.ActionLink("Check Rate", "GetCovidRate", "CovidTracking", new { state = item.address_obj.state }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
           Write(Html.ActionLink(item.name, "Details", new { id = item.location_id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 53 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
                  
                    var img = item.photo.images.thumbnail;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=", 1491, "", 1504, 1);
#nullable restore
#line 56 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
WriteAttributeValue("", 1496, img.url, 1496, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("height", " height=", 1504, "", 1523, 1);
#nullable restore
#line 56 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
WriteAttributeValue("", 1512, img.height, 1512, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("width", " width=", 1523, "", 1540, 1);
#nullable restore
#line 56 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
WriteAttributeValue("", 1530, img.width, 1530, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </td>\n");
#nullable restore
#line 58 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46843abb5eb9ed531cb933c026f6fad07115ceb68772", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
                                                                              WriteLiteral(item.location_id);

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
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 63 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 65 "/Users/kylenedbal/Projects/GCFinalProject/SafeTripTravelCompanion/SafeTripTravelCompanion/Views/TripAdvisor/Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SafeTripTravelCompanion.Models.TripAdvisor.Location.DataLocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
