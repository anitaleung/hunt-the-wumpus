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
        bool isRight = false;



        public TriviaUI(Trivia t, int indexofrightanswer)
        {
            InitializeComponent();
            this.indexofrightanswer = indexofrightanswer;
            trivia = t;
        }

        // Display question
        public void SetQuestion(string question)
        {
            labelQuestion.Text = question;
        }

        // Display answer 1
        public void SetAnswer1(string answer)
        {
            labelanswer1.Text = answer;
        }

        // Display answer 2
        public void SetAnswer2(string answer)
        {
            labelanswer2.Text = answer;
        }

        // Display answer 3
        public void SetAnswer3(string answer)
        {
            labelanswer3.Text = answer;
        }

        // Display answer 4
        public void SetAnswer4(string answer)
        {
            labelanswer4.Text = answer;
        }

        private void buttonanswer1_Click(object sender, EventArgs e)
        {
            trivia.recordAnswer(indexofrightanswer == 1);
            if (indexofrightanswer == 1)
            {
                isRight = true;
            }
            this.Close();
            this.Dispose();
        }

        private void buttonanswer2_Click(object sender, EventArgs e)
        {
            trivia.recordAnswer(indexofrightanswer == 2);
            if (indexofrightanswer == 2)
            {
                isRight = true;
            }
            this.Close();
            this.Dispose();

        }

        private void buttonanswer3_Click(object sender, EventArgs e)
        {
            trivia.recordAnswer(indexofrightanswer == 3);
            if (indexofrightanswer == 3)
            {
                isRight = true;
            }
            this.Close();
            this.Dispose();
        }

        private void buttonanswer4_Click(object sender, EventArgs e)
        {
            trivia.recordAnswer(indexofrightanswer == 4);
            if (indexofrightanswer == 4)
            {
                isRight = true;
            }
            this.Close();
            this.Dispose();
        }

        public bool isCorrect()
        {
            return isRight;
        }

        private void TriviaUI_Load(object sender, EventArgs e)
        {

        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }


    }
}
