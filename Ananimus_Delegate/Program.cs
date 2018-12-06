using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananimus_Delegate
{
    class Program
    {
        public delegate int Mydelegate(int x);
        static void Main(string[] args)
        {
            Mydelegate mydelegate = delegate (int x) { return x * 2; };
            mydelegate = (x) => { return x * 2; };
            mydelegate = x => { return x * 2; };
            int res = mydelegate(4);
            Console.WriteLine(res);
        }


    }
}
