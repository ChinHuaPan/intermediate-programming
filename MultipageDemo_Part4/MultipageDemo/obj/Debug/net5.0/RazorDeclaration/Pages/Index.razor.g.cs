// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MultipageDemo.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/jay/NU/DGM6308_Winter2023/MultipageDemo_Part4/MultipageDemo/Pages/Index.razor"
       

    private void IncrementScore()
    {
        AppData.playerScores[AppData.currentPlayer]++;
        Console.WriteLine("Player " + AppData.currentPlayer + " has "
            + AppData.playerScores[AppData.currentPlayer]);
        NextPlayer();
    }

    private void NextPlayer()
    {
        AppData.currentPlayer++;
        if (AppData.currentPlayer >= AppData.playerScores.Count()) AppData.currentPlayer = 0;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AppData AppData { get; set; }
    }
}
#pragma warning restore 1591
