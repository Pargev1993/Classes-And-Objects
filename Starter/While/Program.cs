using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string First, Second;
            while (true)
            {
                Console.Write("Enter First number ");
                First = Console.ReadLine();
                if (First == "Q" )
                    break;
                Console.Write("Enter second number ");
                Second = Console.ReadLine();
                if (Second == "Q")
                    break;
                if (Second == "0")
                    Console.WriteLine("Number cannot divide in 0!");
                else
                {

                    try
                    {
                        Console.WriteLine("Result of " + First + "/" + Second + " = " + double.Parse(First) / double.Parse(Second));
                    }
                    catch
                    {
                        Console.WriteLine("Have note value! Enter 'Q' for exit");
                    }

                    // THIS CODE WRONG!
                }
            }
        }
    }
}
