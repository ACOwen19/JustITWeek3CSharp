using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------SIMPLE FOR LOOP ARRAY POPULATION-----------
            //decimal[] inputNumbers = new decimal[5];
            //decimal total = 0;

            //for (int i = 0; i < 5; i+=1)
            //{
            //    Console.Write("Please enter a number for the array: ");
            //    inputNumbers[i] = Convert.ToDecimal(Console.ReadLine());
            //    total += inputNumbers[i];
            //}

            //Console.WriteLine("Total is: " + total);
            //decimal average = total/inputnumbers.length
            //Console.WriteLine("Average is: " + average);

            //--------------NESTED FOR LOOP ARRAY POPULATION----------------------

            decimal[,] gridArray = new decimal[4, 5];
            decimal contents = 0;
            decimal columnTotal = 0;
            decimal total = 0;
            decimal rowTotal = 0;
          
            for (int c = 0; c < gridArray.GetLength(0); c += 1)
            {
                Console.WriteLine();
                for (int r = 0; r < gridArray.GetLength(1); r += 1)
                {
                    gridArray[c, r] = contents;
                    Console.Write(contents + "\t");
                    contents += 1;
                    rowTotal += gridArray[c, r];
                    total += gridArray[c, r];
                }
                Console.Write(rowTotal);
                rowTotal = 0;

            }
            Console.WriteLine();
            for (int r = 0; r < gridArray.GetLength(1); r += 1)
            {
                
                for (int c = 0; c < gridArray.GetLength(0); c += 1)
                {
                    
                    columnTotal += gridArray[c, r];
                }
                Console.Write(columnTotal + "\t");
                columnTotal = 0;
            }


            Console.Write(total + "\n");

            //------------SIMPLE FOR & FOREACH LOOPS WITH ARRAYS---------------

            //string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Grumpy", "Dopey", "Bashful" };

            //for (int i = 0; i < sevenDwarves.Length; i += 1)
            //{
            //    Console.WriteLine(sevenDwarves[i] + " your dinner is ready!");
            //}

            //foreach(string dwarf in sevenDwarves)
            //{
            //    Console.WriteLine(dwarf + " your drink is ready!");
            //}

            //---------USER INPUT WITH FOR & FOREACH?? LOOPS PLUS ARRAYS----------------------
                           
            string[,] dwarfMeal = new string[7, 3];
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Grumpy", "Dopey", "Bashful" };

            for (int i = 0; i < dwarfMeal.GetLength(0); i += 1)
            {
                dwarfMeal[i, 0] = sevenDwarves[i];
            }

            for (int i = 0; i < dwarfMeal.GetLength(0); i += 1)
            {
                Console.WriteLine(dwarfMeal[i, 0] + " what do you want for dinner?");
                string dinner = Console.ReadLine();
                dwarfMeal[i, 1] = dinner;
                Console.WriteLine("And to drink?");
                string drink = Console.ReadLine();
                dwarfMeal[i, 2] = drink;
            }

            for (int i = 0; i < dwarfMeal.GetLength(0); i += 1)
            {
                Console.WriteLine(dwarfMeal[i, 0] + " you are having " + dwarfMeal[i, 1] + " for dinner and " + dwarfMeal[i, 2] + " to drink.");
            }
        }
    }
}
