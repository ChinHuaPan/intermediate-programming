#pragma checksum "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e19bfe6967b8c8a1129ce2641ab7cf76eb2a5c47"
// <auto-generated/>
#pragma warning disable 1591
namespace anna_hw2_PickAUniqueCardBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using anna_hw2_PickAUniqueCardBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/_Imports.razor"
using anna_hw2_PickAUniqueCardBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    small{\n        margin-top: 10px;\n    }\n</style>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-8");
            __builder.AddMarkupContent(7, "<div class=\"row\"><h3>How many cards should I pick?</h3></div>\n            \n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row mt-5");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "range");
            __builder.AddAttribute(12, "class", "col-10 form-control-range");
            __builder.AddAttribute(13, "min", "1");
            __builder.AddAttribute(14, "max", "52");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                               numberOfCards

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => numberOfCards = __value, numberOfCards));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-2");
            __builder.AddContent(20, 
#nullable restore
#line 20 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                    numberOfCards

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n            \n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row mt-5");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                  UpdateCards

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\n                    Pick Some Cards\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n            \n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "small");
            __builder.AddContent(33, 
#nullable restore
#line 33 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                        reminder

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n\n            \n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row mt-5");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-warning");
            __builder.AddAttribute(40, "style", "display:" + (
#nullable restore
#line 38 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                                                              showResetBtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                  Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\n                    Shuffle\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n\n\n            \n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.OpenElement(46, "small");
            __builder.AddAttribute(47, "style", "display:" + (
#nullable restore
#line 47 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                       showWarning

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, 
#nullable restore
#line 47 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                                     warning

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n\n        \n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-4");
            __builder.OpenElement(52, "ul");
            __builder.AddAttribute(53, "class", "list-group");
#nullable restore
#line 58 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                 foreach (var card in pickedCards)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "list-group-item");
            __builder.AddContent(56, 
#nullable restore
#line 60 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
                                                 card

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 61 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
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
#line 69 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
      
    int numberOfCards = 5; //set inital value as 5
    string[] pickedCards = new string[0]; //create an array with string type, length is 0
    int leftCardsNum = 52;
    string reminder = "Good luck!";
    string warning = "Choose less cards or shuffle the cards";
    string showWarning = "none";
    string showResetBtn = "none";

    //onclick event of button
    void UpdateCards()
    {
        leftCardsNum = CardPicker.LeftCardsNum();

        if (numberOfCards == leftCardsNum)
        {
            Pick();

            reminder = "Cards clear";
            warning = "Shuffle the cards";

            Block();
        }
        else if (numberOfCards < leftCardsNum)
        {
            Pick();

            reminder = leftCardsNum + " cards left";
            warning = "Choose less cards or shuffle the cards";
        }
        else{
            Block();
        }

    }

    void Pick()
    {
        //Use method "PickSomeCards" in class "CardPicker" to pick cards
        //and pass to pickedCards
        pickedCards = CardPicker.PickSomeCards(numberOfCards);
        leftCardsNum = CardPicker.LeftCardsNum();
    }

    void Reset()
    {
        CardPicker.initializeCards();

        pickedCards = new string[0];

        leftCardsNum = 52;
        numberOfCards = 5;

        showWarning = "none";
        showResetBtn = "none";

        reminder = "Reset!  " + leftCardsNum + " cards left";
    }

    void Block()
    {

        showWarning = "block";
        showResetBtn = "block";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591