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
        String[,] questionlist;
        int numQsRight;
        int numberofqsaskedround;
        int[] askedquestion = new int[5];
        int caveNumber;

        public Trivia(int cn)
        {
            caveNumber = cn;
            String[] lines = File.ReadAllLines("C:\\Users\\lauri_000\\Desktop\\TextFiles\\triviaqs1.csv"); // Read in trivia questions file based on cave number
            //[] file = File.ReadAllLines("C:\\Users\\cleung\\Desktop\\TextFiles\\triviaqs1.csv"); // Read in trivia questions file based on cave number
            questionlist = new String[9, 5]; // Make new question list 

            questionlist = new String[lines.Length, 5];
            for (int i = 0; i < lines.Length; i++)
            {
                String[] question = lines[i].Split(',');
                //Console.WriteLine("lines=" + lines[i]);
                for (int j = 0; j < 5; j++)
                {
                    //Console.WriteLine(questionlist.GetLength(0));
                    //Console.WriteLine(questionlist.GetLength(1));
                    //Console.WriteLine(question.GetLength(0));
                    //Console.WriteLine("i=" + i+","+ "j=" + j);
                    questionlist[i, j] = question[j];

                }
            }
        }

        public bool newRoundofTrivia(int cn, int totalnumberofqstoask)
        {
            // Save data into local variables
            numberofqsaskedround = totalnumberofqstoask;
            caveNumber = cn;
            caveNumber -= 1; // Decrease caveNumber count
            askQuestion(); // Ask question
            return true;
        }

        public void recordAnswer(bool isRight)
        {
            // If got answer correct, increase question right score
            if (isRight == true)
            {
                numQsRight++; 
            }

            if (numberofqsaskedround > 0)
            {
                askQuestion();
            }

        }

        private void askQuestion()
        {
            // Generate random number between 1 and 4
            Random r = new Random();
            int indexofrightanswer = r.Next(4) + 1;

            int numberofqstoask = caveNumber * 10;
            numberofqstoask += askedquestion[caveNumber];

            TriviaUI ui = new TriviaUI(this, indexofrightanswer);
            ui.SetQuestion(questionlist[numberofqstoask, 0]);

            // Now ask the question
            ui.SetAnswer1(indexofrightanswer == 1 ? questionlist[numberofqstoask, 1] : questionlist[numberofqstoask, indexofrightanswer]);
            ui.SetAnswer2(indexofrightanswer == 2 ? questionlist[numberofqstoask, 1] : questionlist[numberofqstoask, 2]);
            ui.SetAnswer3(indexofrightanswer == 3 ? questionlist[numberofqstoask, 1] : questionlist[numberofqstoask, 3]);
            ui.SetAnswer4(indexofrightanswer == 4 ? questionlist[numberofqstoask, 1] : questionlist[numberofqstoask, 4]);
            askedquestion[caveNumber] += 1;
            numberofqsaskedround--;
            ui.ShowDialog();

        }


    }
}
