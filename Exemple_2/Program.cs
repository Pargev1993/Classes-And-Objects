using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_2_Use_of_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckNum result = new CheckNum();
            for (int i = 2; i < 10; i++)
                if (result.IsPrim(i)) Console.WriteLine(i + " Prime number.");
                else Console.WriteLine(i + "  not prime number.");
            Console.ReadKey();
        }
    }
}
