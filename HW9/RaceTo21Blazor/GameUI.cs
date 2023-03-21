﻿using System;

namespace RaceTo21Blazor
{
    public class GameUI
    {

        static public string ShowOverReason = "hidden";
        static public string playerBlockWidth = "col-8";
        static public string OverReasonDescription;
        static public string scoreStyle = "";
        static public string inactiveStatus = "hidden";
        static public string blockStatus = "";
        static public string scoreWin = "";
        static public string nameStyle = "";
        static public string showPlayerChoices = "d-block";
        static public string showGameChoices = "d-none";
        static public bool isGameOver = false;
        static public string showModal = "d-none";
        static public string showReRenderBtn = "d-none";
        static public string showCrown = "d-none";

        static public int activeNum = Game.players.Count;
        static public int potentialWinnerNum = 0;
        static public int stayNum = 0;
        
        public GameUI()
        {
        }

    }
}