using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class MyClass
    {
        private int[] Array = new int[5];

        public int this [int index]
        {
            get { return Array[index]; }
            set { Array[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my[0] = 1;
            my[1] = 2;
            my[2] = 3;
            my[3] = 4;
            my[4] = 5;

        }
    }
}
