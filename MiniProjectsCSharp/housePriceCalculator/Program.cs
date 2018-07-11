using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housePriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[,] london = new double[10, 2];
            double[,] birmingham = new double[10, 2];
            double[,] manchester = new double[10, 2];
            double[,] usedCity = new double[10, 2];
            double[] year = { 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998 };
            double baseLonGrow = 0.05;
            double baseBirGrow = 0.02;
            double baseManGrow = 0.03;
            double yearLonGrow = 0.04;
            double yearBirGrow = 0.03;
            double yearManGrow = 0.05;
            string inCity = "";
            bool checkCity = false;
            double inYear = 0;
            bool checkYear = false;
            int yearIndex = 0;
            double inPrice = 0;
            double newPrice = 0;
            double growthPer = 0;
            

            for (int i=0;i< year.Length ; i+=1)
            {
                london[i, 0] = year[i];
                london[i, 1] = baseLonGrow;
                birmingham[i, 0] = year[i];
                birmingham[i, 1] = baseBirGrow;
                manchester[i, 0] = year[i];
                manchester[i, 1] = baseManGrow;

                baseLonGrow += yearLonGrow;
                baseBirGrow += yearBirGrow;
                baseManGrow += yearManGrow;

            }

            Console.WriteLine("House Price Calculator Mini-Project\nPlease choose a city and which year you bought your house and how much you bought it for.\nThe calculator will work out how much it is worth in 1999!\nPlease choose a city (London, Manchester or Birmingham):");
            inCity = Console.ReadLine().ToLower();
            while (!checkCity)
            {
                if (inCity == "london")
                {
                    usedCity = london;
                    checkCity = true;
                }
                else if (inCity == "birmingham")
                {
                    usedCity = birmingham;
                    checkCity = true;
                }
                else if (inCity == "manchester")
                {
                    usedCity = manchester;
                    checkCity = true;
                }
                else
                {
                    Console.WriteLine("Please select a valid city:");
                    inCity = Console.ReadLine().ToLower();
                }
            }
            Console.WriteLine("Please choose a year (1989-1998):");
            inYear = Convert.ToDouble(Console.ReadLine());
            while (!checkYear)
            {
                for(int i =0; i<year.Length; i += 1)
                {
                    if(usedCity[i,0] == inYear)
                    {
                        checkYear = true;
                        yearIndex = i;
                    }
                }
                if (!checkYear)
                {
                    Console.WriteLine("Please select a valid city:");
                    inYear = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("Please enter how much you bought your house for:");
            inPrice = Convert.ToDouble(Console.ReadLine());

            newPrice = (inPrice + (inPrice * usedCity[yearIndex, 1]));

            growthPer = usedCity[yearIndex, 1] * 100;

            Console.WriteLine("Your house is now worth: £{0}. The price has grown by {1}%",newPrice,growthPer);
            

        }
    }
}
