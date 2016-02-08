using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class Map
    {
        int[] batLocations;
        int[] pitLocations;
        int WumpusLocation;

        public Map()
        {
            Random rnd = new Random(3);
            //Set all bat locations
            //randomly generate 2 bat locations
            int bLocation1 = (rnd.Next(1, 31));  // creates a number between 1 and 30
            int bLocation2 = (rnd.Next(1, 31));
            if (bLocation1 == bLocation2)
            {
                if (bLocation1 < 30)
                {
                    bLocation2 = bLocation1 + 1;
                }
                if (bLocation1 == 30)
                {
                    bLocation2 = 1;
                }
            }
            batLocations = new int[2];
            batLocations[0] = bLocation1;
            batLocations[1] = bLocation2;

            List<int> occupiedRooms = new List<int>();
            occupiedRooms.Add(bLocation1);
            occupiedRooms.Add(bLocation2);

            //Set all pit locations
            int pLocation1 = getNewRoom(occupiedRooms, rnd);
            occupiedRooms.Add(pLocation1);
            int pLocation2 = getNewRoom(occupiedRooms, rnd);
            occupiedRooms.Add(pLocation2);
            pitLocations = new int[2];
            pitLocations[0] = pLocation1;
            pitLocations[1] = pLocation2;

            //Set wumpus location
            int wLocation = getNewRoom(occupiedRooms, rnd);
            occupiedRooms.Add(wLocation);


        }

       
        private int getNewRoom(List<int> occupiedRooms, Random rnd)
        {
            bool equal = false;
            do
            {
                int newRoom = (rnd.Next(1, 31));
                if (occupiedRooms.Contains(newRoom))
                {
                    newRoom = (rnd.Next(1, 31));
                    equal = true;
                }
                else
                {
                    equal = false;
                }

            }
            while (equal);
            return 0;
        }

        public Boolean wumpusMet()
        {
            if (currentCave = wLocation)
            {
                return true;
            }
            //if wumpus is awoken, wumpus changes to random location 
             
            //tracks whether or not player has met Wumpus during movement.
        }

        //Are there bats in this room?
        public Boolean areThereBats(int room)
        {
            if (currentCave = bLocation1 || currentCave = bLocation2)
            {
                return true;    
            }
            
        }

        //Is there a pit in this room?
        public Boolean isTherePit(int room)
        {
            if (currentCave == pLocation1 || currentCave == pLocation2 )
            {
                return true;
            }
        }

        public String warningMessage(String w)
        {
            //checks if there are bats one room away
            //
            int count = 0;
            if (bLocation1 == returnConnectedCaves || bLocation2 == returnConnectedCaves)  {
                return "Bats Nearby";
               }
            else if (pLocation1 == returnConnectedCaves || pLocation2 == returnConnectedCaves) 
            {
                return "I feel a draft";
            }
           // Return what hazards are in room
        }
    }


    public class GameState
    {
        private Cave Cave;
        private Map Map;
        private Player Player;

        public GameState(Cave cave, Map map, Player player)
        {
            Cave = cave;
            Map = map;
            Player = player;
        }
        /*public int[] ConnectedCaves()
        {
            Cave.returnConnectedCaves(Player.getLocation());

        }*/

    }
}
