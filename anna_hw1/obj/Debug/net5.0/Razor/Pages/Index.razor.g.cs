#pragma checksum "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "028144be91345ae14a434859f5d7cebaf4958a25"
// <auto-generated/>
#pragma warning disable 1591
namespace anna_hw1.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using anna_hw1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/_Imports.razor"
using anna_hw1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
using System.Collections.Generic;

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
    .container {
        width: 400px;
    }

    .btn-animal {
        width: 100px;
        height: 100px;
        font-size: 50px;
    }

    .btn-play {
        width: 200px;
        height: 80px;
        font-size: 30px;
    }

    .hidden {
        visibility: hidden;
    }

    .show {
        visibility: visible;
    }

    .center{
        display: flex;
        justify-content: center;
        align-content: center:
    }
</style>




");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 43 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
         for (var animalNumber = 0; animalNumber < shuffledAnimals.Count; animalNumber++)
        {
            var animal = shuffledAnimals[animalNumber]; // animal emoji
            var showAnimal = showAnimals[animalNumber]; // show animal
            var btnId = $"btn-{animalNumber}"; // btn ID
            var indexAnimal = animalNumber; //index of current animal


#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
                                    () => ButtonClick(animal, indexAnimal)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", "btn btn-outline-dark btn-animal");
            __builder.AddAttribute(11, "id", 
#nullable restore
#line 53 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
                                                                    btnId

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(12, "h1");
            __builder.AddContent(13, 
#nullable restore
#line 55 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
                         showAnimal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n    \n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row center");
            __builder.OpenElement(17, "h2");
            __builder.AddContent(18, "Score: ");
            __builder.AddContent(19, 
#nullable restore
#line 64 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
                    score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n    \n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row center");
            __builder.OpenElement(23, "h2");
            __builder.AddContent(24, "Time: ");
            __builder.AddContent(25, 
#nullable restore
#line 69 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
                   timeDisplay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n\n    \n    \n    ");
            __builder.AddMarkupContent(27, "<div class=\"row\"><h2>Good Job!</h2></div>\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row center");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
                             () => ButtonPlayAgainClick()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-outline-dark btn-play");
            __builder.AddAttribute(34, "id", "btnPlay");
            __builder.AddMarkupContent(35, "<scan>play again</scan>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1/Pages/Index.razor"
      

    //declare animals
    List<string> animalEmoji = new List<string>()
{
        "🦊","🦊",
        "🐷","🐷",
        "🐨","🐨",
        "🐣","🐣",
        "🐬","🐬",
        "🦑","🦑",
        "🦔","🦔",
        "🐿","🐿",
    };

    //declare variables
    List<string> shuffledAnimals = new List<string>(); //a list to store sheffled animals
    List<string> showAnimals; // create a list to store the status (show/hidden) of animals
    int matchesFound = 0; //amount of matches the player found
    Timer timer; // timer to show how much time passes
    int tenthsOfSecondElapsed = 0; //how many 1/10 seconds elapsed
    string timeDisplay = "Ready?"; //time to display

    // override OnInitalized function
    protected override void OnInitialized()
    {
        timer = new Timer(100); //timer to count 100 millisecond (0.1 second)
        timer.Elapsed += Timer_Tick; //elapsed time + Timer_tick, then give it back to elapsed time
        SetUpGame(); //initial the game
    }

    //declare variables
    string lastAnimalFound; //note which animal is found last time
    int lastIndex; //note the index of last animal
    int[] chosenIndex; //note last chosen 2 index (last and last one, last one)
    int score = 0; //note the score
    int lastTimeMatched = 0; //note the timing of last successful match
    int timeBetweenMatches = 0; //calculate the length of time period between two successful match


    //initial the game
    private void SetUpGame()
    {
        Random random = new Random(); //random class

        /*shuffle animals by input random numbers into OrderBy function.
        Then convert the type to list and give it back to shuffled animal variable*/
        shuffledAnimals = animalEmoji.OrderBy(item => random.Next()).ToList();

        showAnimals = new List<string>(); // create a new list with string type to showAnimals
        animalEmoji.ForEach(x => showAnimals.Add("?")); // add "?" to showAnimals list for "amount of animalEmoji" times


        matchesFound = 0; //reset matchesFound
        tenthsOfSecondElapsed = 0; //reset the time elapsed
        lastAnimalFound = String.Empty; //reset lastAnimalFound
        lastIndex = -1; //reset last index

        timeDisplay = "Ready?";//reset time display
        chosenIndex = new int[2] { -1, -1 }; //reset 
        lastTimeMatched = 0; //reset time
        score = 0; //reset score
    }


    private void ButtonClick(string animal, int indexAnimal)
    {

        //if the player click the one which is already flipped or matched, do nothing (return)
        if (showAnimals[indexAnimal] != "?" || shuffledAnimals[indexAnimal] == "Matched") { return; }

        /********* check wheather hidden the cards or not ***********/
        //clicked at least 2 animals
        //if last 2 animals are not empty and they are different
        if (chosenIndex[0] > -1 && chosenIndex[1] > -1 && chosenIndex[0] != chosenIndex[1])
        {


            show(indexAnimal);//show current animal
            hiddenUnmateched(chosenIndex[1], chosenIndex[0]);//hidden last 2 animals

            lastAnimalFound = animal; //pass current animal to lastAnimalFound
            lastIndex = indexAnimal; //pass current index to last index

            chosenIndex[0] = indexAnimal; //pass current animal to the 1st animal
            chosenIndex[1] = -1; //reset the 2nd aniaml

            return;//then do nothing
        }

        show(indexAnimal);//show current animal emoji


        /************ check wheather match is successful or not **************/
        //if there is no animal found or the player matched successfully last time
        if (lastAnimalFound == string.Empty)
        {
            lastAnimalFound = animal; //give current animal to lastAnimalFound
            lastIndex = indexAnimal; //pass current index to last index
            chosenIndex[0] = indexAnimal; //store the 1st anmimal
            timer.Start(); //timer starts
        }
        //if match successfully
        //if last animal equals to current animal and last index doesn't eaual to current index
        else if ((lastAnimalFound == animal) && (lastIndex != indexAnimal))
        {
            shuffledAnimals[lastIndex] = "Matched"; //mark last animal as "Matched"
            shuffledAnimals[indexAnimal] = "Matched"; //mark current animal as "Matched"

            lastAnimalFound = string.Empty; //clear lastAnimalFound (we don't need to compare this one to another next time)
            lastIndex = -1; //reset lastindex
            chosenIndex[0] = -1; //reset 1st animal
            chosenIndex[1] = -1; //reset 2nd animal


            matchesFound++; //matchesFound +1 and pass back to matchesFound

            score = score + calScore(); //calculate the score
        }
        //if matche failed
        else
        {

            lastAnimalFound = string.Empty; //clear lastAnimalFound (we don't need to compare this one to another next time)
            lastIndex = -1; //reset last Index
            chosenIndex[1] = indexAnimal; //store the 2nd animal
        }

        //if all matches are found
        if (matchesFound == 8)
        {
            timer.Stop(); // timer stops
            return;
        }

    }

    /*** show ***/
    /***
    input: int index
    output: none
    ***/
    private void show(int index)
    {
        if (shuffledAnimals[index] != "Matched")
        {
            showAnimals[index] = shuffledAnimals[index];
        }

    }

    /*** hiddenUnmateched ***/
    /***
    input: int index, int lastIndex
    output: none
    ***/
    private void hiddenUnmateched(int index, int lastIndex)
    {
        showAnimals[index] = "?";
        showAnimals[lastIndex] = "?";
    }

    /*** ButtonPlayAgainClick ***/
    /***
    input: none
    output: none
    ***/
    //onclick event of play again button
    private void ButtonPlayAgainClick()
    {
        SetUpGame();// reset the game

    }


    /*** Timer_Tick ***/
    /***
    input: none
    output: none
    ***/
    //timer
    private void Timer_Tick(Object source, ElapsedEventArgs e)
    {
        InvokeAsync(() =>
        {
            tenthsOfSecondElapsed++;//plus 1 per 0.1 second

            /*divide tenthsOfSecondElapsed by 10 to convert to second with float type
            convert to string with 0.0s format and pass to timeDisplay*/
            timeDisplay = (tenthsOfSecondElapsed / 10F).ToString("0.0s");
            StateHasChanged(); //notify the component that state has changed || reference: https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.componentbase.statehaschanged?view=aspnetcore-7.0

        });
    }


    /*** calScore ***/
    /***
    input: none
    output: (score depends on timeBetweenMatches)
    ***/
    private int calScore()
    {

        timeBetweenMatches = tenthsOfSecondElapsed - lastTimeMatched; //calculate how long the player matches successfully since last time

        lastTimeMatched = tenthsOfSecondElapsed; //pass current timing to lastTimeMatched

        //return score depends on timeBetweenMatches
        if (timeBetweenMatches <= 5)
        {
            return 1500;
        }else if(timeBetweenMatches <= 10)
        {
            return 1200;
        }else if (timeBetweenMatches <= 20)
        {
            return 1000;
        }else if(timeBetweenMatches <= 30)
        {
            return 800;
        }else if(timeBetweenMatches <= 50)
        {
            return 500;
        }else if(timeBetweenMatches <= 70)
        {
            return 300;
        }else if(timeBetweenMatches <= 100)
        {
            return 200;
        }else
        {
            return 100;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
