using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class PlayGame : Form
    {
        Control _GameControl;
        int[] connectedRooms;
        int currentRoom = 1;
        int coinNum = 0;
        int arrowCount;

        public PlayGame(Control gc)
        {
            InitializeComponent();

            wumpus.Hide(); // Hide wumpus 
            bats.Hide(); // Hide bat 

            // Initialize game control
            _GameControl = gc; 

            // Set player image
            player.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\front 1.png");

            // Set bat and Wumpus images
            wumpus.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wumpus.png");
            bats.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\bat.png");
        }

        public void newGame()
        {
            // Refesh background
            this.refresh();

            CaveSelection caves = new CaveSelection(_GameControl);
            caves.Show(); // Show cave selection
        }

        public void refresh()
        {
            // Tell control that player moved rooms
            _GameControl.playerMovedRooms(currentRoom);

            // Set connected rooms
            connectedRooms = _GameControl.getConnectedRooms(currentRoom);

            // Set cave background (if room is 0 then set wall there)
            if (connectedRooms[0] == 0)
            {
                north.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wall n.png");
                nDoor.Hide();
            }
            else
            {
                north.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\n.png");
                nDoor.Show();
            }

            if (connectedRooms[1] == 0)
            {
                northeast.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wall ne.png");
                neDoor.Hide();
            }
            else
            {
                northeast.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\ne.png");
                neDoor.Show();
            }

            if (connectedRooms[2] == 0)
            {
                southeast.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wall se.png");
                seDoor.Hide();
            }
            else
            {
                southeast.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\se.png");
                seDoor.Show();
            }

            if (connectedRooms[3] == 0)
            {
                south.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wall s.png");
                sDoor.Hide();
            }
            else
            {
                south.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\s.png");
                sDoor.Show();
            }

            if (connectedRooms[4] == 0)
            {
                southwest.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wall sw.png");
                swDoor.Hide();
            }
            else
            {
                southwest.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\sw.png");
                swDoor.Show();
            }

            if (connectedRooms[5] == 0)
            {
                northwest.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wall nw.png");
                nwDoor.Hide();
            }
            else
            {
                northwest.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\nw.png");
                nwDoor.Show();
            }

            // Increase coin count
            coinNum++;
            coinCount.Text = "Coins: " + coinNum.ToString();

            // Increase arrow count
            arrowCountUI.Text = "Arrows: " + getArrowCount().ToString();
        }

        public int getArrowCount()
        {
            return _GameControl.getArrowCount();
        }


        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            // Set connected rooms
            connectedRooms = _GameControl.getConnectedRooms(currentRoom);

            // Move the player
            if (e.KeyChar == 'a')
            {
                this.player.Left = this.player.Left - 5; // Move west
                // Change background image to west
             //   player.BackgroundImage = Image.FromFile(@"C:\Users\lauri_000\Desktop\TextFiles\RapunzelNew\Rapunzel\Player\rapunzel left 1.png");
                player.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\left 1.png");
            }

            if (e.KeyChar == 'w')
            {
                this.player.Top = this.player.Top - 5; // Move north
                // Change bg image to north
               // player.BackgroundImage = Image.FromFile(@"C:\Users\lauri_000\Desktop\TextFiles\RapunzelNew\Rapunzel\Player\rapunzel back 1.png");
                player.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\back 1.png");
            }
            if (e.KeyChar == 'd')
            {
                this.player.Left = this.player.Left + 5; // Move east
                // Change bg image to east
             //   player.BackgroundImage = Image.FromFile(@"C:\Users\lauri_000\Desktop\TextFiles\RapunzelNew\Rapunzel\Player\rapunzel right 1.png");
                player.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\right 1.png");
            }
            if (e.KeyChar == 's')
            {
                this.player.Top = this.player.Top + 5; // Move south
                // Change bg image to south
               // player.BackgroundImage = Image.FromFile(@"C:\Users\lauri_000\Desktop\TextFiles\RapunzelNew\Rapunzel\Player\rapunzel front 1.png");
                player.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\front 1.png");
            }

           // When player touches doors
            if (player.Bounds.IntersectsWith(nDoor.Bounds) && connectedRooms[0] != 0)
            {
                currentRoom = connectedRooms[0]; // Change room to touched tunnel
                player.Location = new Point(298, 383); // Reset location of player
                this.refresh();
            }

            if (player.Bounds.IntersectsWith(neDoor.Bounds) && connectedRooms[1] != 0)
            {
                currentRoom = connectedRooms[1]; // Change room to touched tunnel
                player.Location = new Point(173, 313); // Reset location of player
                this.refresh();
            }

            if (player.Bounds.IntersectsWith(seDoor.Bounds) && connectedRooms[2] != 0)
            {
                currentRoom = connectedRooms[2]; // Change room to touched tunnel
                player.Location = new Point(173, 174); // Reset location of player
                this.refresh();
            }

            if (player.Bounds.IntersectsWith(sDoor.Bounds) && connectedRooms[3] != 0)
            {
                currentRoom = connectedRooms[3]; // Change room to touched tunnel
                player.Location = new Point(298, 101); // Reset location of player
                this.refresh();
            }

            if (player.Bounds.IntersectsWith(swDoor.Bounds) && connectedRooms[4] != 0)
            {
                currentRoom = connectedRooms[4]; // Change room to touched tunnel
                player.Location = new Point(426, 189); // Reset location of player
                this.refresh();
            }

            if (player.Bounds.IntersectsWith(nwDoor.Bounds) && connectedRooms[5] != 0)
            {
                currentRoom = connectedRooms[5]; // Change room to touched tunnel
                player.Location = new Point(416, 311); // Reset location of player
                this.refresh();
            }

            // Display cave room number onto screen
            roomLabel.Text = "Room " + currentRoom;

        }

        public void setMessages(String message)
        {
            messageBox.Text = message;
        }

        // Display Wumpus
        public void showWumpus()
        {
            wumpus.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wumpus.png");
            wumpus.Show();
        }

        // Hide Wumpus
        public void hideWumpus()
        {
            wumpus.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\wumpus.png");
            wumpus.Hide();
        }

        // Display bats
        public void showBats()
        {
            bats.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\bat.png");
            bats.Show();
        }

        // Hide bats
        public void hideBats()
        {
            bats.BackgroundImage = Image.FromFile("C:\\Users\\lauri_000\\Desktop\\TextFiles\\" + _GameControl.getCaveNumber() + "\\bat.png");
            bats.Hide();
        }


            //System.Diagnostics.Debug.WriteLine(player.Right);
           // System.Diagnostics.Debug.WriteLine(south);


 
               // System.Diagnostics.Debug.WriteLine("HEY");





       
        private void north_Click(object sender, EventArgs e)
        {

        }

        private void northwest_Click(object sender, EventArgs e)
        {

        }


        private void northeast_Click(object sender, EventArgs e)
        {

        }

        private void southwest_Click(object sender, EventArgs e)
        {

        }

        private void south_Click(object sender, EventArgs e)
        {

        }

        private void southeast_Click(object sender, EventArgs e)
        {

        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void arrowCount_Click(object sender, EventArgs e)
        {

        }

        private void southeast_Click_1(object sender, EventArgs e)
        {

        }






    }
}
