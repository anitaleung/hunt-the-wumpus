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
    public partial class TriviaUI : Form
    {
        private int indexofrightanswer;
        private Trivia trivia;
        
       
        public TriviaUI(Trivia t, int indexofrightanswer)
        {
            InitializeComponent();
            this.indexofrightanswer = indexofrightanswer;
            trivia = t;
        }
        public void SetQuestion(string question)
        {
            labelQuestion.Text = question;
        }
        public void SetAnswer1(string answer)
        {
            labelanswer1.Text = answer;
        }
        public void SetAnswer2(string answer)
        {
            labelanswer2.Text = answer;
        }
        public void SetAnswer3(string answer)
        {
            labelanswer3.Text = answer;
        }
        public void SetAnswer4(string answer)
        {
            labelanswer4.Text = answer;
        }

        private void buttonanswer1_Click(object sender, EventArgs e)
        {
            trivia.recordanswer(indexofrightanswer == 1);
            this.Close();
            this.Dispose();
        }

        private void buttonanswer2_Click(object sender, EventArgs e)
        {
            trivia.recordanswer(indexofrightanswer == 2);
            this.Close();
            this.Dispose();

        }

        private void buttonanswer3_Click(object sender, EventArgs e)
        {
            trivia.recordanswer(indexofrightanswer == 3);
            this.Close();
            this.Dispose();
        }

        private void buttonanswer4_Click(object sender, EventArgs e)
        {
            trivia.recordanswer(indexofrightanswer == 4);
            this.Close();
            this.Dispose();
        }

        private void TriviaUI_Load(object sender, EventArgs e)
        {

        }

    
    }
}
