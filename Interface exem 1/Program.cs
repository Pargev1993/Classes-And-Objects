using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_exem_1
{
    interface IInterface
    {
        void eat();
    }
    class Myckass:IInterface
    {
        public void eat()
        {
            Console.WriteLine("Eat");
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Myckass v;
            v.eat();
        }
    }
}
