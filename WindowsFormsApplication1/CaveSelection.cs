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
    public partial class CaveSelection : Form
    {
        Control _GameControl;

        public CaveSelection(Control gc)
        {
            InitializeComponent();
            _GameControl = gc;
        }
        
        // Pass in cave number to control and create new cave
        private void cave_Click(object sender, EventArgs e)
        {
            var img = (PictureBox)sender;
            switch (img.Name) 
            {
                case "cave1":
                    _GameControl.selectCave(1);
                    break;
                case "cave2":
                    _GameControl.selectCave(2);
                    break;
                case "cave3":
                    _GameControl.selectCave(3);
                    break;
                case "cave4":
                    _GameControl.selectCave(4);
                    break;
                case "cave5":
                    _GameControl.selectCave(5);
                    break;
                default:
                    break;
             }
            this.Hide();
        }

        private void Caves_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         

        
  
    }
}
