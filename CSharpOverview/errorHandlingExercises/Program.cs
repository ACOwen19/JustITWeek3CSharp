using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorHandlingExercises
{

    //------------------------------ARGUMENT EXCEPTION THROWER--------------

    class ArgumentTest
    {
        public static string ProcessMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("Message can't be null");
            }
            else
            {
                string output = message;
                return output;
            }

        }
    }

    public class AutomatedTest
    {
        public static int CalculatorOne(int valueOne, int valueTwo)
        {
            int result = valueOne + valueTwo;
            return result;

        }

        public static int CalculatorTwo(int valueOne, int valueTwo)
        {
            int result = valueOne * valueTwo;
            return result;

        }
    }


    
    class Program
    {

        static void Main(string[] args)
        {
            //--------------------INDEX OUT OF RANGE EXCEPTION EXAMPLE--------------

            decimal[] inputNumbers = new decimal[5];
            decimal value = 1;
            decimal total = 0;


            try
            {
                for (int i = 0; i < 6; i += 1)
                {
                    inputNumbers[i] = value;
                    value += 1;
                    total += inputNumbers[i];
                }
            }
            catch (IndexOutOfRangeException triedOutput)
            {
                Console.WriteLine(triedOutput.ToString());
            }
            finally
            {
                Console.WriteLine("Array length is: " + inputNumbers.Length + "\nThe total of the array is: " + total);
            }

            //---------------------------DIVIDE BY ZERO EXCEPTION TEST---------------------

            int numOne = 4;
            int numTwo = 0;
            int result = 0;

            try
            {
                result = numOne / numTwo;
            }
            catch (DivideByZeroException triedMaths)
            {
                Console.WriteLine(triedMaths.ToString());
            }
            finally
            {
                Console.WriteLine("{0} divided by {1} = {2}", numOne, numTwo, result);
            }

            //------------------ARGUMENT EXCEPTION TEST-----------------------

            string testMes = "";
            string testMesOne = null;
            string testMesTwo = "Test Message";

            try
            {
                testMes = ArgumentTest.ProcessMessage(testMesOne);
                Console.WriteLine(testMes);
            }
            catch (ArgumentNullException triedMes)
            {
                Console.WriteLine("ERROR!");
                //Console.WriteLine(triedMes.ToString());
            }
            try
            {
                testMes = ArgumentTest.ProcessMessage(testMesTwo);
                Console.WriteLine(testMes);
            }
            catch (ArgumentNullException triedMes)
            {
                Console.WriteLine(triedMes.ToString()); ;
            }

            //---------------------DEGUGGER TEST------------------

            int numOneA = 4;
            int numTwoB = 0;
            int resultC = 0;
            
            resultC = numOneA / numTwoB;

            int resultD = AutomatedTest.CalculatorOne(numOneA, numTwoB);


            Console.WriteLine(resultC);

            }

    }
}

