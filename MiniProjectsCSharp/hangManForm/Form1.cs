using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangManForm
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
        }

        static string[] randomWords = { "green", "blue", "yellow", "red", "orange", "indigo", "violet" };
        static Random rnd = new Random();

        static int randNum = rnd.Next(0, 7);
        static string answer = randomWords[randNum];
        static int wordLength = answer.Length;
        char[] answerChars = answer.ToCharArray();
        char[] answerCheck = new char[wordLength];
        static int lives = 0;
        bool guessCheck = false;
        bool retry = false;
        char userGuess = ' ';
        //char[] answerChars = answer.ToCharArray();
        //char[] answerCheck = new char[wordLength];
        string answerMatch = "";
       
        static string CheckAnswer(char[] answerCheck)
        {
            string answerMatch = new string(answerCheck);
            return answerMatch;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel3.Visible = true;


            foreach (Control label in panel2.Controls)
            {
                if(Convert.ToInt32(label.Tag) <= wordLength)
                {
                    label.Visible = true;
                }
            }
              
            
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            userGuess = Convert.ToChar(guess.Text);

            for (int i = 0; i < wordLength; i += 1)
            {
               if (userGuess == answerChars[i])
                {
                    guessCheck = true;
                    answerCheck[i] = answerChars[i];
                    foreach (Control labels in panel2.Controls)
                    {
                        if (Convert.ToInt32(labels.Tag) == i + 1)
                        {
                            labels.Text = Convert.ToString(answerChars[i]);
                        }
                }

                }
            }
            if (guessCheck)
            {
                
            }

            else
            {

            }


            while (answer != answerMatch && lives < 5)
            {
                for (int i = 0; i < wordLength; i += 1)
                {
                    if (answerCheck[i] == userGuess)
                    {
                        retry = true;
                    }

                    else if (userGuess == answerChars[i])
                    {
                        guessCheck = true;
                        answerCheck[i] = answerChars[i];
                    }

                }

                if (retry)
                {
                    Console.WriteLine("You've already got that one!");
                }

                else if (guessCheck)
                {
                    Console.WriteLine("Well done!");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    lives += 1;
                }


                guessCheck = false;
                retry = false;
                answerMatch = CheckAnswer(answerCheck);

                if (answer == answerMatch)
                {
                    Console.WriteLine("Congratulations, the answer was {0}. You won the game!", answer);
                }

                else if (lives >= 5)
                {
                    Console.WriteLine("Sorry, you ran out of guesses. The answer was {0}, you lost the game!", answer);
                }

                else
                {
                    Console.WriteLine("Guess again:");
                    userGuess = Convert.ToChar(Console.ReadLine());
                }
            }
        }
    }
}
