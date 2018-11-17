using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exem_2
{
    abstract class AbstractClass1
    {
        public abstract void Opperation1();
    }
    abstract class AbstractClass2:AbstractClass1
    {
        public abstract void Opperation2();
    }
    class ConcrettClass:AbstractClass2
    {
        public override void Opperation1()
        {
            Console.WriteLine("Concret Class Operation 1");
        }
        public override void Opperation2()
        {
            Console.WriteLine("Concret Class Operation2");        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass2 class2 = new ConcrettClass();
            class2.Opperation1();
            class2.Opperation2();
            AbstractClass1 class1 = new ConcrettClass();
            class1.Opperation1();
            Console.ReadKey();
        }
    }
}
