using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemp_2
{
     class ConcretClass
    {
        public void opperation()
        {
            Console.WriteLine(" Concret Opperation ");
        }
    }

    abstract class AbstractClass:ConcretClass
    {
        public abstract void Method();
    }

    class ConcretClass2:AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Concret class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass concretClass = new ConcretClass2();
            concretClass.opperation();
            concretClass.Method();
            Console.ReadKey();
        }
    }
}
