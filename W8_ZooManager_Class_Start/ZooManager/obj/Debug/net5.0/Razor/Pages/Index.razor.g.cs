#pragma checksum "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a9487943ff69b1306cd92d25e4e4516ec114635"
// <auto-generated/>
#pragma warning disable 1591
namespace ZooManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/_Imports.razor"
using ZooManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
using ZooManager;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    button {
        width: 75px;
        height: 75px;
        font-size: 50px;
    }

        button.sm {
            display: inline-flex;
            width: 50px;
            height: 50px;
            justify-content: center;
            align-items: center;
            font-size: 30px;
        }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-6\"><h1 style=\"text-align:end\">Add Zones:</h1></div>\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-1");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddZones(Direction.down)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(12, "<h2>⏬</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-1");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddZones(Direction.right)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(20, "<h2>⏩</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.AddMarkupContent(22, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddMarkupContent(25, "<div class=\"col-6\"><h1 style=\"text-align:end\">Add to Holding:</h1></div>\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-1");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("cat")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(32, "<h2>🐱</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-1");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("mouse")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(40, "<h2>🐭</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-1");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("grass")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(48, "<h2>🌾</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-1");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("boulder")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(56, "<h2>🪨</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-1");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                () => Game.AddToHolding("elephant")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "sm btn btn-outline-dark");
            __builder.AddMarkupContent(64, "<h2>🐘</h2>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n    ");
            __builder.AddMarkupContent(66, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row");
            __builder.AddMarkupContent(69, "<div class=\"col-6\"><h1 style=\"text-align:end\">Holding Pen:</h1></div>");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-6");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "disabled");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "btn btn-outline-dark");
            __builder.OpenElement(76, "h2");
            __builder.AddContent(77, 
#nullable restore
#line 90 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                     Game.holdingPen.emoji

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(78, "sup");
            __builder.AddContent(79, 
#nullable restore
#line 90 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                                Game.holdingPen.rtLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n    ");
            __builder.AddMarkupContent(81, "<div class=\"row\"><div class=\"col\"><hr></div></div>\n    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col");
            __builder.OpenElement(86, "table");
            __builder.AddAttribute(87, "align", "center");
#nullable restore
#line 102 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                 for (var y = 0; y < Game.numCellsY; y++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "tr");
#nullable restore
#line 105 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                         for (var x = 0; x < Game.numCellsX; x++)
                        {
                            var a = Game.animalZones[y][x];

#line default
#line hidden
#nullable disable
            __builder.OpenElement(89, "td");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                                    () => Game.ZoneClick(a)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "type", "button");
            __builder.AddAttribute(93, "class", "btn btn-outline-dark");
            __builder.OpenElement(94, "h2");
            __builder.AddContent(95, 
#nullable restore
#line 111 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                         a.emoji

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(96, "sup");
            __builder.AddContent(97, 
#nullable restore
#line 111 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                                                      a.rtLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 114 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 116 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/Week8/W8_ZooManager_Class_Start/ZooManager/Pages/Index.razor"
       
    protected override void OnInitialized()
    {
        Game.SetUpGame();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
