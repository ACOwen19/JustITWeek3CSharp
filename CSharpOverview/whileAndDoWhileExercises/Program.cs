using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileAndDoWhileExercises
{
    class Program
    {
        static bool correctEntry = false;

        public static int guessChecker(int guesses)
        {
            if (guesses == 2)
            {
                Console.WriteLine("Sorry, you ran out of guesses");
            }

            else if (guesses == 5)
            {
                Console.WriteLine("You gave up on this one.");
            }
            else
            {
                guesses++;
                Console.WriteLine("Well Done! You got it in " + guesses + "!");
            }
            
            correctEntry = false;

            guesses = 0;

            return guesses;
        }


        static void Main(string[] args)
        {

         
            string answerOneA = "EGG";
            string answerOneB = "EGGS";

            string answerTwoA = "TIME";
            string answerTwoB = "TIMES";

            string answerThreeA = "FISH";
            string answerThreeB = "FISHES";

            

            int guesses = 0;
            int score = 0;

            Console.WriteLine("Riddles in the Dark! You have 3 guesses per riddle. To give up on a riddle just type Quit");

            Console.WriteLine("A box without hinges, key or lid, Yet golden treasure inside is hid.");
            Console.WriteLine("Enter your guess");

            string userAnswer = Console.ReadLine().ToUpper();

            while (correctEntry == false && guesses < 2)
            {
                if (userAnswer == "QUIT")
                {
                    guesses = 5;
                   }
                else
                {
                    if (userAnswer == answerOneA || userAnswer == answerOneB)
                    {
                        correctEntry = true;
                        score++;
                    }
                    
                    else {
                        guesses++;
                        Console.WriteLine("Try again! Guesses remaining: " + (3 - guesses));
                        Console.WriteLine("Enter your guess");
                        userAnswer = Console.ReadLine().ToUpper();

                    }
                }
            }

            guesses = guessChecker(guesses);

            //if (guesses == 2)
            //{
            //    Console.WriteLine("Sorry, you ran out of guesses");
            //}

            //else if (guesses == 5)
            //{
            //    Console.WriteLine("You gave up on this one.");
            //}
            //else
            //{
            //    guesses++;
            //    Console.WriteLine("Well Done! You got it in " + guesses + "!");
            //}
            //guesses = 0;
            //correctEntry = false;

            Console.WriteLine();
            Console.WriteLine("If you thought that one was tricky try this:");
            Console.WriteLine();
            Console.WriteLine("This thing all things devours:");
            Console.WriteLine("Birds, beasts, trees, flowers");
            Console.WriteLine("Gnaws iron, bites steel; Grinds hard stones to meal");
            Console.WriteLine("Slays king, ruins town, And beats high mountain down.");

            do
            {
                Console.WriteLine("Enter your guess");
                userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == "QUIT")
                {
                    guesses = 5;                    
                   }

                else if (userAnswer == answerTwoA || userAnswer == answerTwoB)
                {
                    correctEntry = true;
                    score++;
                }

                else
                {
                guesses++;
                    Console.WriteLine("Try again! Guesses remaining: " + (3 - guesses));
                }
            } while (correctEntry == false && guesses < 2);

           // guessChecker();

            if (guesses == 2)
            {
                Console.WriteLine("Sorry, you ran out of guesses");
            }

            else if (guesses == 5)
            {
                Console.WriteLine("You gave up on this one.");
            }
            else
            {
                guesses++;
                Console.WriteLine("Well Done! You got it in " + guesses + "!");
            }
            guesses = 0;
            correctEntry = false;

            Console.WriteLine();
            Console.WriteLine("Now for the final challenge:");
            Console.WriteLine();
            Console.WriteLine("Alive without breath,");
            Console.WriteLine("As cold as death;");
            Console.WriteLine("Never thirsty, ever drinking,");
            Console.WriteLine("All in mail never clinking");

            do
            {
                Console.WriteLine("Enter your guess");
                userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == "QUIT")
                {
                    guesses = 5;
                }

                else if (userAnswer == answerThreeA || userAnswer == answerThreeB)
                {
                    correctEntry = true;
                    score++;
                }

                else
                {
                    guesses++;
                    Console.WriteLine("Try again! Guesses remaining: " + (3 - guesses));
                }
            } while (correctEntry == false && guesses < 2);

            // guessChecker();

            if (guesses == 2)
            {
                Console.WriteLine("Sorry, you ran out of guesses");
            }

            else if (guesses == 5)
            {
                Console.WriteLine("You gave up on this one.");
            }
            else
            {
                guesses++;
                Console.WriteLine("Well Done! You got it in " + guesses + "!");
            }
            guesses = 0;
            correctEntry = false;


            Console.WriteLine("Your final score is " + score + "/3");

        }
    }
}
