using System;
using System.Collections.Generic;

namespace ZooManager
{
    public class Game
    {
        static public int numCellsX = 4;
        static public int numCellsY = 4;

        static private int maxCellsX = 10;
        static private int maxCellsY = 10;


        static public List<List<Zone>> creatureZones = new List<List<Zone>>();
        static public Zone holdingPen = new Zone(-1, -1, null);

        /*********** SetUpGame() *************
         * Set up the game
         * Called by Index.razor
         * INPUT: none
         * OUTPUT: none
         * **/
        static public void SetUpGame()
        {
            for (var y = 0; y < numCellsY; y++)
            {
                List<Zone> rowList = new List<Zone>();
                // Note one-line variation of for loop below!
                for (var x = 0; x < numCellsX; x++) rowList.Add(new Zone(x, y, null));
                creatureZones.Add(rowList);
            }
        }

        /*********** AddZones() *************
         * Add a row or a column from left or down
         * Called by Index.razor
         * INPUT: Direction d --> the direction that the players would like to add row or column
         * OUTPUT: none
         * **/
        static public void AddZones(Direction d)
        {
            if (d == Direction.down || d == Direction.up)
            {
                if (numCellsY >= maxCellsY) return; // hit maximum height!
                List<Zone> rowList = new List<Zone>();
                for (var x = 0; x < numCellsX; x++)
                {
                    rowList.Add(new Zone(x, numCellsY, null));
                }
                numCellsY++;
                if (d == Direction.down) creatureZones.Add(rowList);
                // if (d == Direction.up) creatureZones.Insert(0, rowList);
            }
            else // must be left or right...
            {
                if (numCellsX >= maxCellsX) return; // hit maximum width!
                for (var y = 0; y < numCellsY; y++)
                {
                    var rowList = creatureZones[y];
                    // if (d == Direction.left) rowList.Insert(0, new Zone(null));
                    if (d == Direction.right) rowList.Add(new Zone(numCellsX, y, null));
                }
                numCellsX++;
            }
        }

        /*********** ZoneClick() *************
         * Click any zone
         * Called by Index.razor
         * INPUT: Zone clickedZone --> which zone the player clicks
         * OUTPUT: none
         * **/
        static public void ZoneClick(Zone clickedZone)
        {
            Console.Write("Got creature ");
            Console.WriteLine(clickedZone.emoji == "" ? "none" : clickedZone.emoji);
            Console.Write("Held creature is ");
            Console.WriteLine(holdingPen.emoji == "" ? "none" : holdingPen.emoji);
            if (clickedZone.occupant != null) clickedZone.occupant.ReportLocation();
            if (holdingPen.occupant == null && clickedZone.occupant != null)
            {
                // take creature from zone to holding pen
                Console.WriteLine("Taking " + clickedZone.emoji);
                holdingPen.occupant = clickedZone.occupant;
                holdingPen.occupant.location.x = -1;
                holdingPen.occupant.location.y = -1;
                clickedZone.occupant = null;
                ActivateCreatures();
            }
            else if (holdingPen.occupant != null && clickedZone.occupant == null)
            {
                // put creature in zone from holding pen
                Console.WriteLine("Placing " + holdingPen.emoji);
                clickedZone.occupant = holdingPen.occupant;
                clickedZone.occupant.location = clickedZone.location;
                holdingPen.occupant = null;
                Console.WriteLine("Empty spot now holds: " + clickedZone.emoji);
                ActivateCreatures();
            }
            else if (holdingPen.occupant != null && clickedZone.occupant != null)
            {
                Console.WriteLine("Could not place creature.");
                // Don't activate creatures since user didn't get to do anything
            }
        }

        /*********** AddCreatureToHolding() *************
         * Add the creature that the player clicks to holding
         * Called by Index.razor
         * INPUT: string creatureType --> the creature type
         * OUTPUT: none
         * **/
        static public void AddCreatureToHolding(string creatureType)
        {
            if (holdingPen.occupant != null) return;
            if (creatureType == "cat") holdingPen.occupant = new Cat("Fluffy");
            if (creatureType == "mouse") holdingPen.occupant = new Mouse("Squeaky");
            if (creatureType == "raptor") holdingPen.occupant = new Raptor("Flashy");
            if (creatureType == "chick") holdingPen.occupant = new Chick("Clucky");
            if (creatureType == "alien") holdingPen.occupant = new Alien("Ety");
            Console.WriteLine($"Holding pen occupant at {holdingPen.occupant.location.x},{holdingPen.occupant.location.y}");
            ActivateCreatures();
        }

        /////////////// 👉 o: fix multiple Activate()  /////////////////
        /*********** ActivateCreatures() *************
         * Make every creature activate based on its own conditions
         * Called by Game class
         * INPUT: none
         * OUTPUT: none
         * **/
        static private void ActivateCreatures()
        {
            for (var r = 1; r < 11; r++) // reaction times from 1 to 10
            {
                //go through every zones
                for (var y = 0; y < numCellsY; y++)
                {
                    for (var x = 0; x < numCellsX; x++)
                    {
                        var zone = creatureZones[y][x];
                        if (zone.occupant != null && zone.occupant.reactionTime == r)
                        {
                            if(zone.occupant.Activate()) return;
                        }
                    }
                }
            }
        }
    }
}

