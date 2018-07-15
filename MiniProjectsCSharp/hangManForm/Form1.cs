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

        public static string[] randomWords = { "green", "blue", "yellow", "red", "orange", "indigo", "violet" };
        public static Random rnd = new Random();

        public static int randNum = rnd.Next(0, 7);
        public static string answer = randomWords[randNum];
        public static int wordLength = answer.Length;
        public static char[] answerChars = answer.ToCharArray();
        public static char[] answerCheck = new char[wordLength];
        public static int lives = 0;
        public static bool guessCheck = false;
        public char userGuess = ' ';
        public string answerMatch = "";

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
                if (Convert.ToInt32(label.Tag) <= wordLength)
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
            if (guessCheck == true)
            {
                answerMatch = CheckAnswer(answerCheck);

                if (answerMatch == answer)
                {
                    Result.Text = "You got it! The word was " + answer;
                    feedback.ForeColor = Color.Green;
                    feedback.Text = "\u00fc";
                    guessCheck = false;
                    guessButton.Enabled = false;
                }
                else
                {
                    Result.Text = "Well Done! Keep Guessing";
                    feedback.ForeColor = Color.Green;
                    feedback.Text = "\u00fc";
                    guessCheck = false;
                }
            }

            else
            {
                lives += 1;

                if (lives == 1)
                {
                    head.Visible = true;
                    Result.Text = "Incorrect, guess again";
                    feedback.ForeColor = Color.Red;
                    feedback.Text = "\u00fb";
                }
                else if (lives == 2)
                {
                    body.Visible = true;
                    Result.Text = "Incorrect, guess again";
                    feedback.ForeColor = Color.Red;
                    feedback.Text = "\u00fb";
                }
                else if (lives == 3)
                {
                    armOne.Visible = true;
                    Result.Text = "Incorrect, guess again";
                    feedback.ForeColor = Color.Red;
                    feedback.Text = "\u00fb";
                }
                else if (lives == 4)
                {
                    armTwo.Visible = true;
                    Result.Text = "Incorrect, guess again";
                    feedback.ForeColor = Color.Red;
                    feedback.Text = "\u00fb";
                }

                else if (lives == 5)
                {
                    legs.Visible = true;
                    guessButton.Enabled = false;
                    Result.Text = "You lost, the word was " + answer;
                    feedback.ForeColor = Color.PaleVioletRed;
                    feedback.Text = "\u00fb";
                }

            }


        }
    }
}
