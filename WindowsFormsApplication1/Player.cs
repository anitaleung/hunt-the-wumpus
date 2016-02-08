using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class Player
    {

        private int arrowCount = 3;
        private int playerRoom = 1;
        private int playerLocation = 1;

        public Player()
        {
        }
        
        // Return number of coins
        public int numberOfCoins()
        {
            return 100;
        }

        // Return current player location
        public int getLocation()
        {
            return playerRoom;
        }

        // Set player's location after the player moves rooms
        public void setLocation(int newRoom)
        {
            playerLocation = newRoom;
        }

        // Change player location randomly
        public void changeLocation()
        {
            Random rnd = new Random();
            playerLocation = (rnd.Next(1, 31));
        }

        // Return number of arrows
        public int getArrows()
        {
            return arrowCount;
        }

        // Increase number of arrows by 2
        public void increaseArrows()
        {
            arrowCount += 2;
        }

        // Decrease number of arrows by 1
        public int decreaseArrow()
        {
            arrowCount -= 1;
            return arrowCount;
        }


    }

}