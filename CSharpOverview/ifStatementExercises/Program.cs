using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatementExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(); // Only Random

            int randNum = rnd.Next(1, 26); // 1 is inclusive, 26 isn't, will give 1-25. Only Random

            //int myNum = 19; // Not used for random

            // Console.WriteLine("Please guess a number:"); // Only used for IF & IF ELSE

            //   int userNum = Convert.ToInt32(Console.ReadLine()); // Only used for IF & IF ELSE

            int userNum = 0; // Not used for IF & IF ELSE

            // ----------------------------------IF & IF ELSE-----------------------------------

            //if (myNum == userNum)
            //{

            //    Console.WriteLine("Congratulations, you guessed correctly!");

            //}

            //else if (myNum < userNum)
            //{

            //    Console.WriteLine("Too high!");
            //}

            //else {

            //    Console.WriteLine("Too Low!");
            //------------------------------------------DO WHILE-------------------------------------
            //};

            //do
            //{
            //        Console.WriteLine("Please guess a number:");
            //        userNum = Convert.ToInt32(Console.ReadLine());
            //    if (myNum < userNum)
            //    {


            //        Console.WriteLine("Too high!");

            //    }
            //    else if (myNum > userNum)
            //    {

            //        Console.WriteLine("Too Low!");

            //    }

            //    else
            //    {

            //       //Console.WriteLine("Congratulations, the number was " + myNum + ". You guessed correctly!");

            //    }


            //} while (myNum != userNum);



            do
            {
                Console.WriteLine("Please guess a number between 1 & 25:");
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum <= 25 && userNum >= 1)
                {

                    if (randNum < userNum)
                    {

                        Console.WriteLine("Too high!");
                     
                    }

                    else if(randNum > userNum)
                    {
                        Console.WriteLine("Too Low!");
                    }

                    else
                    {

                        Console.WriteLine("Congratulations, the number was " + randNum + ". You guessed correctly!");

                    }
                }

                else
                {
                    Console.WriteLine("Out of Range!");

                }

            } while (randNum != userNum);
              
        }
    }
}
