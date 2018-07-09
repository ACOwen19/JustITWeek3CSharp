using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------SIMPLE TIMES TABLES ---------------------------------
            //Console.WriteLine("The 2 times table:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i + " x 2 = " + (i*2));
            //}
            //Console.WriteLine();
            //Console.WriteLine("The 3 times table:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i + " x 3 = " + (i * 3));
            //}
            //Console.WriteLine();
            //Console.WriteLine("The 4 times table:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i + " x 4 = " + (i * 4));
            //}

            // ----------------------TIMES TABLES TEST - RANDOM NUMBER ------------------------

            //Random rnd = new Random();
            //int randMult = rnd.Next(1, 13);

            //Console.WriteLine("What is 2 x " + randMult + "?");

            //int userGuess = Convert.ToInt32(Console.ReadLine());


            //    int answer = (randMult * 2);

            //    if (answer == userGuess)
            //    {
            //        Console.WriteLine("Well Done, thats right!")
            //    }
            //else {
            //    Console.WriteLine("Sorry thats Wrong");
            //}

            // ------------------------TIMES TABLES ITTERATION ----------------

            int score = 0;
            Console.WriteLine("You are being tested on your two times tables:");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("What is " + i + " x 2?");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == (i * 2))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }

                else
                {
                    Console.WriteLine("Try again");
                    i--;
                    score--;
                }

            }

            Console.WriteLine("Quiz Complete, you scored: " + score + "/12.");
        }
    }
}
