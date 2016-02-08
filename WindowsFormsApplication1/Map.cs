using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class Map
    {
        private int[] batLocations;
        private int[] pitLocations;
        private int currentCave;
        private int wLocation;
        private int bLocation1;
        private int bLocation2;
        private int pLocation1;
        private int pLocation2;
        List<int> occupiedRooms = new List<int>();

        public Map(int currentC)
        {
            // Save current cave into local variable
            currentCave = currentC;

            // Set all bat locations
            Random rnd = new Random();
            bLocation1 = (rnd.Next(1, 31));  // creates a number between 1 and 30
            bLocation2 = (rnd.Next(1, 31));

            // If both bats location are same, add one to second bat's location
            if (bLocation1 == bLocation2)
            {
                bLocation2 += 1;
            }

            // Store array of two bat locations
            batLocations = new int[2];
            batLocations[0] = bLocation1;
            batLocations[1] = bLocation2;

            // Add bat locations into list of occupied rooms
            occupiedRooms.Add(bLocation1);
            occupiedRooms.Add(bLocation2);

            // Set all pit locations
            pLocation1 = getNewRoom(occupiedRooms, rnd);
            pLocation2 = getNewRoom(occupiedRooms, rnd);

            // Add pit locations into list of occupied rooms
            occupiedRooms.Add(pLocation1);
            occupiedRooms.Add(pLocation2);

            // Store array of two pit locations
            pitLocations = new int[2];
            pitLocations[0] = pLocation1;
            pitLocations[1] = pLocation2;

            //Set wumpus location
            wLocation = 25;

            // Add wumpus location into list of occupied rooms
            occupiedRooms.Add(wLocation);
        }

        // Keep generating random rooms until a new one room is generated
        private int getNewRoom(List<int> occupiedRooms, Random rnd)
        {
            bool roomIsNotNew = true;
            int newRoom = 0;
            while (roomIsNotNew) 
            {
                newRoom = (rnd.Next(1, 31)); // Generate random room between 1 and 30
                if (occupiedRooms.Contains(newRoom)) // If newRoom is already reserved
                {
                    newRoom = (rnd.Next(1, 31)); // Generate a new room again
                    roomIsNotNew = true; 
                }
                else
                {
                    roomIsNotNew = false; // Stop while loop, we've found a new room
                }
            }
            return newRoom;    
        }

        // Return true if player runs into Wumpus
        public bool wumpusMet(int enteredRoom)
        {
            if (enteredRoom == wLocation)
            {
                return true;
            }
            return false;
        }

        // Determine whether Wumpus changes room
        public bool wumpusChangesRoom()
        {
            // Generate randomness where likely (70%) Wumpus changes room
            Random rnd = new Random();
            Random gen = new Random();
            int prob = gen.Next(100);
            if (prob < 10)
            {
                wLocation = getNewRoom(occupiedRooms, rnd); // Change Wumpus location
                return true;
            }
            return false;
        }

        // Check if there are bats in the room
        public bool areThereBats(int room)
        {
            if (room == bLocation1 || room == bLocation2)
            {
                return true;
            }
            return false;
        }

        // Check if there is pit in the room
        public bool isTherePit(int room)
        {
            if (currentCave == pLocation1 || currentCave == pLocation2)
            {
                return true;
            }
            return false;
        }

        // Checks if there are bats one room away
        public bool isBatNearby(int[] connectedCaves)
        {
            for (int i = 0; i < 6; i++)
            {
                if (bLocation1 == connectedCaves[i] || bLocation2 == connectedCaves[i])
                {
                    return true;
                }
            }
            return false;
        }

        // Checl if there are bottomless pits one room away
        public bool isPitNearby(int[] connectedCaves)
        {
            for (int i = 0; i < 6; i++)
            {
                if (pLocation1 == connectedCaves[i] || pLocation2 == connectedCaves[i])
                {
                    return true;
                }
            }
            return false;
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

}