using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheWord
{
    class Program
    {
        static void DisplayVisualiser(string[] visualiser, int wordLength)
        {
            for (int i = 0; i < wordLength; i += 1)
            {
                Console.Write(visualiser[i]);
            }
            Console.WriteLine();

        }

        static void DisplayLifeCount(string[] lifeCount, int wordLength)
        {
            for (int i = 0; i < wordLength; i += 1)
            {
                Console.Write(lifeCount[i]);
            }
            Console.WriteLine();

        }
        static string CheckAnswer(char[] answerCheck)
        {
            string answerMatch = new string(answerCheck);
            return answerMatch;
        }

        static void Main(string[] args)
        {

            string[] randomWords = { "green", "blue", "yellow", "red", "orange", "indigo", "violet" };
            Random rnd = new Random();

            int randNum = rnd.Next(0, 7);

            string answer = randomWords[randNum];
            int wordLength = answer.Length;
            int lives = 0;
            bool guessCheck = false;
            bool retry = false;
            char userGuess = ' ';
            char[] answerChars = answer.ToCharArray();
            char[] answerCheck = new char[wordLength];
            string answerMatch = "";
            string[] visualiser = new string[wordLength];
            string[] lifeCount = new string[wordLength];
            for (int i = 0; i < wordLength; i += 1)
            {
                visualiser[i] = "_\t";
            }

            Console.WriteLine("Guess The Word Mini Project\n You have 5 lives.\nThe word is " + wordLength + " letters long, guess a letter!");
            DisplayVisualiser(visualiser, wordLength);

            userGuess = Convert.ToChar(Console.ReadLine());

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
                        visualiser[i] = Convert.ToString(userGuess + "\t");
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
                    lifeCount[lives] = "X\t";
                    lives += 1;
                }

                DisplayVisualiser(visualiser, wordLength);
                DisplayLifeCount(lifeCount, wordLength);
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
