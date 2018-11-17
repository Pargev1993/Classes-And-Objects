using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            concretDirivedClass concretDirivedClass = new concretDirivedClass();
            concretDirivedClass.AbstractMethod3();
            concretDirivedClass.Method1();
            concretDirivedClass.VirtualMethod();
            Console.ReadKey();

        }
    }
}
