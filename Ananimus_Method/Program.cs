using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananimus_Method
{
    class Program
    {
        public delegate void Mydelegate(ref int a, ref int b, out int c);
        static void Main(string[] args)
        {
            int summand = 1, summand1 = 2, sum = 0;
            Mydelegate mydelegate = delegate (ref int a,ref int b,out int c) {  a++; b++; c = a + b; };
            mydelegate(ref summand, ref summand1, out sum);
            Console.WriteLine();
            
        }
    }
}
