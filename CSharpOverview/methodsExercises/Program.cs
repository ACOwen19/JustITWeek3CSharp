using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercises
{
    class Program
    {
        //---------BASIC METHOD, NO RETURN--------
        //static void Message(string name)
        // NB Need to declare the data type of the parameter
        //{
        //Console.WriteLine("Hello " + name + ". How are you?");
        //}


        //   ----------BASIC METHOD, WITH RETURN----------
        //static int AddNumbers(int first, int second)
        //{
        //    int total = first + second;
        //    return total;
        //}


        static string mathsOperator = "";

        static decimal SimpleMaths(decimal first, decimal second)
        {
            decimal output = 0;
            double firstDouble = Convert.ToDouble(first);
            double secondDouble = Convert.ToDouble(second);

            switch (mathsOperator)
            {
                case "+":
                    output = first + second;
                    break;
                case "-":
                    output = first - second;
                    break;
                case "*":
                    output = first * second;
                    break;
                case "/":
                    output = first / second;
                    break;
                case "^":
                    double power = Math.Pow(firstDouble, secondDouble);
                    output = Convert.ToDecimal(power);
                    break;
                case "sine":
                    double sine = Math.Sin(firstDouble);
                    output = Convert.ToDecimal(sine);
                    break;
                case "cos":
                    double cos = Math.Cos(firstDouble);
                    output = Convert.ToDecimal(cos);
                    break;
                case "tan":
                    double tan = Math.Sin(firstDouble);
                    output = Convert.ToDecimal(tan);
                    break;
                case "rec":
                    output = 1 / first;
                    break;
                default:
                    Console.WriteLine("Incorrect operator");
                    break;

            }

            return output;

        }        
        
        static void Main(string[] args)
        {
            // ----------BASIC METHOD, NO RETURN USE----------
            //Console.Write("Please Enter Your Name: ");
            //string enteredName = Console.ReadLine();
            //Message(enteredName);

            // ----------BASIC METHOD, WITH RETURN USE----------
            //Console.WriteLine("Adding Two Numbers");
            //Console.Write("Please Enter The First Number: ");
            //int firstNum = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please Enter The Second Number: ");
            //int secondNum = Convert.ToInt32(Console.ReadLine());

            //int total = AddNumbers(firstNum, secondNum);
            //Console.WriteLine("Total is: " + total);

            Console.WriteLine("Lets Do Some Maths");
            Console.Write("Please choose the operation to do (*, +, -, /, ^, sine, cos, tan, rec): ");
            mathsOperator = Console.ReadLine().ToLower();

            if (mathsOperator != "sine" && mathsOperator != "cos" && mathsOperator != "tan" && mathsOperator != "rec")
            {
                Console.Write("Please Enter The First Number: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Please Enter The Second Number: ");
                decimal secondNum = Convert.ToDecimal(Console.ReadLine());
                decimal total = Convert.ToDecimal(SimpleMaths(firstNum, secondNum));
                Console.WriteLine("Total is: " + total);
            }
            else if (mathsOperator == "rec")
            {
                Console.Write("Please Enter A Number: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());
                decimal reciprocal = Convert.ToDecimal(SimpleMaths(firstNum, 0));
                Console.WriteLine("Reciprocal is: 1/" + firstNum + " = " + reciprocal);
            }
            else
            {
                Console.Write("Please Enter The Angle: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());
                decimal angle = Convert.ToDecimal(SimpleMaths(firstNum, 0));
                Console.WriteLine("The " + mathsOperator + " is: " + angle);

            }
        }
    }
}
