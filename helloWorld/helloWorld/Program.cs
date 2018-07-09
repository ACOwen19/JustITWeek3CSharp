using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args) // Signature for the main method
        {
            Console.WriteLine("Hello World!"); //"cw" + tab + tab will shortcut to Console.WriteLine
            Console.WriteLine("Hello World!);  
        // Note that the compiler won't actually detect the error above (") it but it will tell you the location.
            Console.WriteLine("Hello World!")
        // Console will detect the error above (;) and tell you the location. 
        }
    }
}
// ctrl + F5 will run the program without debugging and leave the console window open