using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
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
          Console.Write("Calculator Mini Project\nPlease choose the operation to do (*, +, -, /, ^, sine, cos, tan, rec): ");
            mathsOperator = Console.ReadLine().ToLower();

            if (mathsOperator == "*" || mathsOperator == "/" || mathsOperator == "+" || mathsOperator == "-" || mathsOperator == "^")
            {
                Console.Write("Please Enter The First Number: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Please Enter The Second Number: ");
                decimal secondNum = Convert.ToDecimal(Console.ReadLine());
                decimal total = Convert.ToDecimal(SimpleMaths(firstNum, secondNum));
                Console.WriteLine("{0} {1} {2} = {3}", firstNum, mathsOperator, secondNum, total);
            }
            else if (mathsOperator == "rec")
            {
                Console.Write("Please Enter A Number: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());
                decimal reciprocal = Convert.ToDecimal(SimpleMaths(firstNum, 0));
                Console.WriteLine("The reciprocal is: 1/{0} = {1}",firstNum, reciprocal);
            }
            else if (mathsOperator == "sine" || mathsOperator == "cos" || mathsOperator == "tan")
            {
                Console.Write("Please Enter The Angle: ");
                decimal firstNum = Convert.ToDecimal(Console.ReadLine());
                decimal angle = Convert.ToDecimal(SimpleMaths(firstNum, 0));
                Console.WriteLine("The " + mathsOperator + " of the angle is: " + angle);
            }
            else
            {
                Console.WriteLine("Incorrect operator");
            }
        }
    }
}
