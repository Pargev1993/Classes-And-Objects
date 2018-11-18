using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
   abstract class AbstractClass
    {
        public abstract void Method();
    }
    class ConcretClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Abstract Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass incstance = new ConcretClass();

            incstance.Method();
            Console.ReadKey();
        }
    }
}
