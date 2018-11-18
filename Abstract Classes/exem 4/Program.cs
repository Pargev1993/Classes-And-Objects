using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exem_4
{
    abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("1 abstract class");
            this.AbstractMethod();
            Console.WriteLine("2 Abstract  Class");

        }
        public abstract void AbstractMethod();
    }
    class ConcretClass:AbstractClass
    {
        string s = "First";
        public ConcretClass()
        {
            Console.WriteLine("3 concret Class");
            s = "Second";
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("Thets oll {0}",s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass Instance = new ConcretClass();
            Instance.AbstractMethod();
            Console.ReadKey();
        }
    }
}
