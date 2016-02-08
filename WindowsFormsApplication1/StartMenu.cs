using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class StartMenu : Form
    {
        // Name objects
        private Control _Control;
        

        public StartMenu()
        {
            InitializeComponent();
        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            // Construct objects
            _Control = new Control();
            _Control.startGame();
            this.Hide();
        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            // Construct objects
            _Control = new Control();
            this.Text = "Constructed high score!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Construct objects
            _Control = new Control();
            this.Text = "Constructed exit!";
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
