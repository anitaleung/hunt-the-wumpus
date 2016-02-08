using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WumpusTest
{
    public class Trivia
    {
        String[,] questionList;
        private int numberofqsright;
        private int numberofqsaskedround;
        private int[] askedquestion = new int[5];
        private int caveNumber;

        // Constructor
        public Trivia(int cn)
        {
            caveNumber = cn; // Set cave number
            String[] lines = File.ReadAllLines(@"C:\Users\lauri_000\Desktop\TextFiles\triviaqs1.csv"); // Read in trivia questions
            questionList = new String[lines.Length, 5]; // Make new 2d array of questions
            // SPopulate questionList
            for (int i = 0; i < lines.Length; i++)
            {
                String[] question = lines[i].Split(',');
                for (int j = 0; j < 5; j++)
                {
                    questionList[i, j] = question[j];
                }
            }
        }

        // Ask trivia questions
        public bool newRoundofTrivia(int cavenumber, int totalnumberofqstoask)
        {
            numberofqsaskedround = totalnumberofqstoask;
            caveNumber = cavenumber;
            caveNumber -= 1;
            AskOneQuestion();
            return true;
        }

        // Set whether answer is correct
        public void recordAnswer(bool rightorwrong)
        {
            if (rightorwrong == true)
            {
                numberofqsright++;
            }
            if (numberofqsaskedround > 0)
            {
                AskOneQuestion();
            }
        }

        // Return number of questions correct
        public int getNumQsRight()
        {
            return numberofqsright;
        }

       // Ask trivia questions
        private void AskOneQuestion()
        {
            Random r = new Random();
            int indexofrightanswer = r.Next(4) + 1; // Generate random number between 1 and 3
            int numberofqstoask = caveNumber * 10;
            numberofqstoask += askedquestion[caveNumber];
            TriviaUI ui = new TriviaUI(this, indexofrightanswer);
            ui.SetQuestion(questionList[numberofqstoask, 0]);
            // Now ask the question
            ui.SetAnswer1(indexofrightanswer == 1 ? questionList[numberofqstoask, 1] : questionList[numberofqstoask, indexofrightanswer]);
            ui.SetAnswer2(indexofrightanswer == 2 ? questionList[numberofqstoask, 1] : questionList[numberofqstoask, 2]);
            ui.SetAnswer3(indexofrightanswer == 3 ? questionList[numberofqstoask, 1] : questionList[numberofqstoask, 3]);
            ui.SetAnswer4(indexofrightanswer == 4 ? questionList[numberofqstoask, 1] : questionList[numberofqstoask, 4]);
            askedquestion[caveNumber] += 1; // Count up number of questions asked
            numberofqsaskedround--; // Count down question round already asked
            ui.ShowDialog(); // Show the trivia UI

        }


    }
}
