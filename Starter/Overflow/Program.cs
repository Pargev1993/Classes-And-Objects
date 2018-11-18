using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 2147483647;
            try       
//check overflow
            {
                checked
                {
                    I = (I * 2);
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("I is overflow!");
            }
            Console.WriteLine("Result can be:"+(long)I*2);
            Console.WriteLine("'I' have Not Changed, his value is: "+I);
            Console.ReadKey();
            int J = 10;
            //J = J++;
            J = ++J;
        
            Console.WriteLine(J);
            Console.ReadKey();
        }
    }
}
