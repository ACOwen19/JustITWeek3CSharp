using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = new string[3];

            Console.WriteLine("Please enter 3 words to be sorted alphabetically");
            userInput[0] = Console.ReadLine();
            userInput[1] = Console.ReadLine();
            userInput[2] = Console.ReadLine();
            bool swap;
            string swapper;

            do
            {
                swap = false;
                for (int i = 0; i < userInput.Length -1; i += 1)
                {
                    string bubbleOne = userInput[i];
                    string bubbleTwo = userInput[i + 1];
                    string remBubOne = bubbleOne.Remove(1);
                    string remBubTwo = bubbleTwo.Remove(1);
                   
                    char bubCharOne = Convert.ToChar(remBubOne);
                    char bubCharTwo = Convert.ToChar(remBubTwo);
                    int hashBubOne = bubCharOne.GetHashCode();
                    int hashBubTwo = bubCharTwo.GetHashCode();
                    
                    if (hashBubTwo < hashBubOne)
                    {
                        swapper = userInput[i];
                        userInput[i] = userInput[i + 1];
                        userInput[i + 1] = swapper;
                        swap = true;
                    }
                    
                }
            } while (swap == true);

            Console.WriteLine(userInput[0] + "\n" + userInput[1] + "\n" + userInput[2]);

           
        }
    }
}
