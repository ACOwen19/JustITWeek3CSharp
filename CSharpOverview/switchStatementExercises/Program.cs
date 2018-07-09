using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchStatementExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------------------------------SINGLE INPUT + CASE SENSITIVITY-----------------

            //string north = "Bears, Lions, Packers, Vikings";
            //string east = "Cowboys, Giants, Eagles, Redskins";
            //string south = "Buccaneers, Falcons, Panthers, Saints ";
            //string west = "Cardinals, Rams, Seahawks, 49ers";

            //Console.WriteLine("There are four divisions in the NFC, please choose either North, South, East or West:");

            //string division = Console.ReadLine().ToLower();
            //string output = "";

            //switch (division)
            //{
            //    case "west":
            //        output = west;
            //        break;
            //    case "east":
            //        output = east;
            //        break;
            //    case "north":
            //        output = north;
            //        break;
            //    case "south":
            //        output = south;
            //        break;
            //    default:
            //        output = "Sorry thats not a division.";
            //        break;
            //}
            //Console.WriteLine(output);

            // -------------------------------MULTIPLE POSSIBLE INPUTS------------------


            string bears = "The Bears are from Chicago, Illinois";
            string lions = "The Lions are from Detroit, Michigan";
            string packers = "The Packers are from Green Bay, Wisconsin";
            string vikings = "The Vikings are from Minneapolis, Minnesota";



            // Prefer if else but switch fine as well (ACO Opinion - subjective)

            string teamEntry = "";
            Boolean correctEntry = false;

            Console.WriteLine("There are four teams in the NFC North: the Green-Bay Packers, Minnesota Vikings, Detroit Lions & Chicago Bears.");

            do
            {
               
                Console.WriteLine("Please choose a team:");
                teamEntry = Console.ReadLine().ToLower();

                if (teamEntry == "green-bay" || teamEntry == "green-bay packers" || teamEntry == "packers")
                {
                    Console.WriteLine(packers);
                    correctEntry = true;
                }

                else if (teamEntry == "detroit" || teamEntry == "detroit lions" || teamEntry == "lions")
                {
                    Console.WriteLine(lions);
                    correctEntry = true;
                }

                else if (teamEntry == "bears" || teamEntry == "chicago bears" || teamEntry == "chicago")
                {
                    Console.WriteLine(bears);
                    correctEntry = true;
                }

                else if (teamEntry == "minnesota" || teamEntry == "minnesota vikings" || teamEntry == "vikings")
                {
                    Console.WriteLine(vikings);
                    correctEntry = true;
                }

                else
                {
                    Console.WriteLine("Sorry thats not a team");
                }

            } while (correctEntry == false);

        // ---- STRING METHOD 
            //string team = Console.ReadLine().ToLower();
            //string output = "";

            //switch (team)
            //{
            //    case "packers":
            //    case "green-bay":
            //    case "green-bay packers":
            //        output = packers;
            //        break;
            //        // Would need to do this for each team
            //    default:
            //        output = "Sorry thats not a team";
            //        break;
            //}
            //Console.WriteLine(output);



        }
    }
}
