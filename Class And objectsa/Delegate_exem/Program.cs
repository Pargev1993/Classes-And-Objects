using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_exem
{
    class Program
    {

        public delegate int Mydelegate(int a,int b);
        static void Main(string[] args)
        {
            int summand = 1, summand1 = 2, sum = 0;
            Mydelegate mydelegate = delegate (int a, int b){ return a + b; };
            sum = mydelegate(summand, summand1);
            Console.WriteLine(sum);
        }

    }
}
