using System;
using System.Collections.Generic;

namespace RaceTo21Blazor
{
    public class CardTable
    {

        /* ********* CalEveryone() **********
        * Calculate the numbers for counters
        * Called by Request() method
        * INPUT: none
        * OUTPUT: none
        */
        static public void CalEveryone()
        {
            GameUI.activeNum = 0;
            GameUI.potentialWinnerNum = 0;
            GameUI.stayNum = 0;

            foreach (var p in Game.players) // check every player
            {
                //active num
                if (p.status == PlayerStatus.active)
                {
                    GameUI.activeNum++;
                }

                //potential winner num
                if (p.status == PlayerStatus.active || p.status == PlayerStatus.stay)
                {
                    GameUI.potentialWinnerNum++;
                }

                //stay num
                if (p.status == PlayerStatus.stay)
                {
                    GameUI.stayNum++;
                }
            }

        }
    }
}