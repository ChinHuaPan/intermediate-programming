// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PickACardBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using PickACardBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/_Imports.razor"
using PickACardBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/Week3CardGame/PickACardBlazor/Pages/Index.razor"
       
    int numberOfCards = 5;
    string[] pickedCards = new string[0];
    void UpdateCards()
    {
        pickedCards = CardPicker.PickSomeCards(numberOfCards);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
