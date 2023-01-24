// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw2_PickAUniqueCardBlazor/Pages/Index.razor"
      
    int numberOfCards = 5; //set inital value as 5
    string[] pickedCards = new string[0]; //create an array with string type, length is 0
    int leftCardsNum = 52; //how many cards are left after picking
    string reminder = "Good luck!"; //reminder message
    string warning = "Choose less cards or shuffle the cards"; //warning message
    string showWarning = "none"; //control the warning message to show or hidden
    string showReshuffleBtn = "none"; //control the shuffle/reset btn to show or hidden

    //onclick event of pick-some-cards
    /*** FUNCTION: UpdateCards ***
    input: none
    output: none
    > pick cards based on the range
    ***/
    void UpdateCards()
    {
        //if the player just pick all the cards (left)
        if (numberOfCards == leftCardsNum)
        {
            Pick(); //pick cards

            reminder = "Cards clear"; //reminder message: there is no card any more
            warning = "Reshuffle the cards"; //warning message: only thing the player can do is reshuffle

            Show(); //show warning message and shuffle btn
        }
        //if the play pick a valid number of cards
        else if (numberOfCards < leftCardsNum)
        {
            Pick(); //pick cards

            reminder = leftCardsNum + " cards left"; //reminder message: show the number of left cards
            warning = "Choose less cards or reshuffle the cards"; //warning message: two options for reference
        }
        //if there is not enough cards for picking
        else
        {
            Show(); //show warning message and shuffle btn

            //do nothing
        }

    }

    //onclick event of reshuffle btn
    /*** FUNCTION: Reshuffle ***
    input: none
    output: none
    > initialize the cards
    ***/
    void Reshuffle()
    {
        CardPicker.initializeCards(); //reset

        pickedCards = new string[0]; //clear pickedCards

        leftCardsNum = 52; //reset leftCardsNum
        numberOfCards = 5; //reset numberOfCards

        showWarning = "none"; //hidden warning message
        showReshuffleBtn = "none"; //hidden reshuffle btn

        reminder = "Reshuffled!  " + leftCardsNum + " cards left"; //reminder message: reshuffled
    }

    /*** FUNCTION: Pick ***
    input: none
    output: none
    > call the methods in CardPicker class to pick cards
    ***/
    void Pick()
    {
        //Use method "PickSomeCards" in class "CardPicker" to pick cards
        //and pass to pickedCards
        pickedCards = CardPicker.PickSomeCards(numberOfCards);
        //get number of left cards
        leftCardsNum = CardPicker.GetLeftCardsNum();
    }

    /*** FUNCTION: Show ***
    input: none
    output: none
    > show the warning message and reshuffle btn
    ***/
    void Show()
    {

        showWarning = "block"; //show warning message
        showReshuffleBtn = "block"; //show reshuffle btn 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
