// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace anna_hw1.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using anna_hw1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/_Imports.razor"
using anna_hw1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/Pages/Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/Pages/Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "/Users/chin-huapan/Documents/Northeastern University/2023winter_DGM6983_Intermediate Programming for Digital Media/intermediate-programming/anna_hw1_FINAL/anna_hw1/Pages/Index.razor"
      

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
        List<string> showAnimals; // create a list to store the animals currently shown on the screen
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

    /*** FUNCTION: SetUpGame ***/
    /***
    input: none
    output: none
    ***/
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

    /*** FUNCTION: ButtonClick ***/
    /***
    input: string animal, int indexAnimal
    output: none
    ***/
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

            //if the player break the record and it's not the first time
            if (compareRecord(score, tenthsOfSecondElapsed) && (highestScore != 0))
            {
                message = "Congratulations! You just broke the record!"; //change message to 
                }
                else
                {
                    message = "Good job!";
                }


            return;

        }

    }

    /*** FUNCTION: show ***/
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

    /*** FUNCTION: hiddenUnmateched ***/
    /***
    input: int index, int lastIndex
    output: none
    ***/
    private void hiddenUnmateched(int index, int lastIndex)
    {
        showAnimals[index] = "?";
        showAnimals[lastIndex] = "?";
    }

    /*** FUNCTION: ButtonPlayAgainClick ***/
    /***
    input: none
    output: none
    ***/
    //onclick event of play again button
    private void ButtonPlayAgainClick()
    {
        if (compareRecord(score, tenthsOfSecondElapsed))
        {
            refreshRecord();
        }

        SetUpGame();// reset the game

    }


    /*** FUNCTION: Timer_Tick ***/
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


    /*** FUNCTION: calScore ***/
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
        }
        else if (timeBetweenMatches <= 10)
        {
            return 1200;
        }
        else if (timeBetweenMatches <= 20)
        {
            return 1000;
        }
        else if (timeBetweenMatches <= 30)
        {
            return 800;
        }
        else if (timeBetweenMatches <= 50)
        {
            return 500;
        }
        else if (timeBetweenMatches <= 70)
        {
            return 300;
        }
        else if (timeBetweenMatches <= 100)
        {
            return 200;
        }
        else
        {
            return 100;
        }
    }

    //declare
    int highestScore = 0;
    int shortestTime = int.MaxValue;
    string shortestTimeDisplay;
    string message = "Good job!";

    private bool compareRecord(int currentScore, int currentTime)
    {

        if(currentScore >= highestScore && currentTime <= shortestTime)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private void refreshRecord()
    {

        highestScore = score;
        shortestTime = tenthsOfSecondElapsed;
        shortestTimeDisplay = (tenthsOfSecondElapsed / 10F).ToString("0.0s");


    }

    /**************************************************************************************/
    /***
    1. Hidden instead of clear
       Hide all animals at first and show the ones that the player matches successfully until the game ends.
         > (A) List<string> showAnimals // create a list to store the status (show/hidden) of animals
         > (A) int lastIndex; //note the index of last animal
         > (A) int[] chosenIndex; //note last chosen 2 indexes (last and last one, last one)
         > (C) Hidden the emoji at first and show all successful matches in the end

    2. The "play-again" button
       Show a "play-again" button instead of just words when the game ends, and it allows the player to play a new game by clicking it.
         > (B) "Good job!" h2 tag
         > (B) "play-again" button
         > (C) Allow the players to play again by clicking the button

    3. Players can score higher if they match faster
       Calculate the time period between 2 successful matches
         > (A) int score = 0; //note the score
         > (A) int lastTimeMatched = 0; //note the timing of last successful match
         > (A) int timeBetweenMatches = 0; //calculate the length of time period between two successful match
         > (C) Build a scoring system and score the players depending on how fast they match successfully
    ***/
    /**************************************************************************************/

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
