using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WumpusTest;

namespace WumpusTest
{
    public class Control 
    {
        private PlayGame _PlayGame;
        private Cave _Cave;
        private Map _Map;
        private Player _Player;
        private Trivia _Trivia;
        private TriviaUI _TriviaUI;

        private int caveNumber;

        
        public Control()
        {
            _Player = new Player(); // Instantiate Player once control is constructed
        }

        // Open playgame form with cave options
		public void startGame() 
        {
            CaveSelection caveSelection = new CaveSelection(this);
            caveSelection.Show();
		}

        public void selectCave(int cn)
        {
            caveNumber = cn; // Set cave number
            _Cave = new Cave(caveNumber); // Instantiate Cave object
            _Trivia = new Trivia(caveNumber); // Instantiate Trivia object
            _Map = new Map(caveNumber);
            // Open new game 
            _PlayGame = new PlayGame(this); // Make new PlayGame object
            _PlayGame.Show();
            
        }

        // Return cave number
        public int getCaveNumber()
        {
            return caveNumber;
        }

        // Get current room number
        public int getRoomNumber()
        {
            return _Player.getLocation();
        }

        // Get connected caves
        public int[] getConnectedRooms(int currentRoom)
        {
            return _Cave.returnConnectedCaves(currentRoom);
        }

        // Player is moved, set new room player is in
        public void playerMovedRooms(int cR)
        {
            // Hide bats
            _PlayGame.hideBats();

            // Set new player location
            _Player.setLocation(cR);

            // If Wumpus is there, display WUmpus message
            if (_Map.wumpusMet(cR) && _Map.wumpusChangesRoom()) // Met Wumpus! Wumpus changed rooms
            {
                _PlayGame.setMessages("You ran into the Wumpus! But it decided to flee.");
            }
            else if (_Map.wumpusMet(cR)) // Met Wumpus! Wumpus doesnt change rooms
            {
                _PlayGame.showWumpus();
                _Trivia.newRoundofTrivia(caveNumber,5); // Ask trivia questions
                _PlayGame.setMessages("You ran into the Wumpus! You have to defeat the Wumpus!");
                if (_Trivia.getNumQsRight() >= 3) // If answered more than 3 questions correct, escape Wupmpus
                {
                    _PlayGame.setMessages("You've successfully escaped the Wumpus!");
                    _PlayGame.hideWumpus();
                }
                else // Failed to answer more than 3 questions correct, end game
                {
                    _PlayGame.setMessages("You've died! :(");
                    _PlayGame.Hide();
                }
                
            }
            
            // If there are bats, display bat message
            if (_Map.areThereBats(cR)) 
            {
                _PlayGame.setMessages("You ran into bats!");
                _PlayGame.showBats();
                _Player.changeLocation();
                //_PlayGame.refresh();
            }

            // If there are pits
            if (_Map.isTherePit(cR))
            {
                 _PlayGame.setMessages("You ran into a bottomless pit!");
                 _Trivia.newRoundofTrivia(caveNumber, 3); // Ask trivia questions
                 if (_Trivia.getNumQsRight() >= 2) // If answered more than 2 questions correct, escape Wupmpus
                 {
                     _PlayGame.setMessages("You've successfully escaped the pit!");
                     _Player.increaseArrows();
                     _PlayGame.hideWumpus();
                 }
                 else // Failed to answer more than 2 questions correct, end game
                 {
                     _PlayGame.setMessages("You've died! :(");
                     _PlayGame.Hide();
                 }
            }

            // If there are pits, display bottomless pit message
            if (_Map.isPitNearby(getConnectedRooms(cR)))
            {
                  _PlayGame.setMessages("I feel a breeze");
            }

            // If bats nearby
            if (_Map.isBatNearby(getConnectedRooms(cR)))
            {
                  _PlayGame.setMessages("I hear bats");
            } 

            
        }

        public int getArrowCount()
        {
            return _Player.getArrows();
        }

       

        // Return room sides with doors
       /* public int[] getRoomSides()
        {
            return _Cave.returnConnectedCaves(caveNumber);
        }*/

        

        // Return cave number
        /*
        public void getRoomNumber()
        {
            //int[,] array = _Cave.getAllRooms();
            //foreach (var item in array)
            //{
            //    //System.Diagnostics.Debug.WriteLine("ALL ROOMS" + _Cave.getAllRooms());
            //    System.Diagnostics.Debug.WriteLine(item.ToString());            
            
            //}
            
            int[] array = _Cave.returnConnectedCaves(caveNumber);
            foreach (var item in array)
            {
                //System.Diagnostics.Debug.WriteLine("ALL ROOMS" + _Cave.getAllRooms());
                System.Diagnostics.Debug.WriteLine(item.ToString());            
            
            }

            
        }
         * 
         * /



		/*
         * Displays high scores
		 * Called if game ended or if player presses on high score option
		 * Output: 
	     * - Call high score object to return score
		 * - Print score onto UI
		 */
        public void showHighScores(bool selectHighScore) 
        {
			// Call the high score object that returns score
            // Print score onto UI
		}

		/*
		 * End game
         * Input: #TODO OBJECT (player? map?) returns player died
		 * Output: Display high score to UI
		 */
        public void endGame() 
        {
			showHighScores(true);
        }

        // Return GameState
      /*  public GameState getGameState()
        {
            return _Map.getGameState();
        }
 */
    }
}