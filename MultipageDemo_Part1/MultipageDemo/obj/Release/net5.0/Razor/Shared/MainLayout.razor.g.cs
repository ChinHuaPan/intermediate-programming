#pragma checksum "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce9220530d6b5779f7ed61593de9b391ea71c97"
// <auto-generated/>
#pragma warning disable 1591
namespace MultipageDemo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using MultipageDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/_Imports.razor"
using MultipageDemo.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-h9bv7ntjbe");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-h9bv7ntjbe");
            __builder.OpenComponent<global::MultipageDemo.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-h9bv7ntjbe");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-h9bv7ntjbe><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-h9bv7ntjbe>About</a></div>\n\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-h9bv7ntjbe");
#nullable restore
#line 14 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo/MultipageDemo/Shared/MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
