#pragma checksum "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/Components/MySecondComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b64196f24b9f5c5efb12d0d38691211609f0ba71"
// <auto-generated/>
#pragma warning disable 1591
namespace MultipageDemo.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using MultipageDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using MultipageDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/_Imports.razor"
using MultipageDemo.Components;

#line default
#line hidden
#nullable disable
    public partial class MySecondComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h2>This is my second component</h2>\n    CurrentCounterValue in MySecondComponent is ");
#nullable restore
#line 3 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/Components/MySecondComponent.razor"
__builder.AddContent(2, CurrentCounterValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/Components/MySecondComponent.razor"
       
    [Parameter]
    public int CurrentCounterValue { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
