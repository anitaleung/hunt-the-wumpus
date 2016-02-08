using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    class GUI
    {
        public GUI()
        {

        }
        public void newGame()
        {

            //display player info (from Game Control)
            //display num of arrow, num of turns, score
            //display hints
            //display actions (move, shoot, purchase arrows, purchase secrets)
        }

        public void getGameControl()
        {
          //  _Control.getGameState();
        }

        public String encountersWumpus()
        {
            //calls Game Control
            //display trivia quesetion
            return "trivia question";
        }
        public void encountersBat()
        {
            //display bats
            //calls Game Control and put player in a different room
        }
        public String fallsIntoPit()
        {
            //display message
            //call Game Control and display trivia question
            return "trivia question";
            
        }
        public void defeatsWumpus()
        {
            //calls Game Control to display high score
        }
    }

}
