using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    public delegate void Mydelegate(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate mydelegate = null;
            mydelegate = (int i) =>
              {
                  i--;
                  Console.WriteLine(i);
                  if (i > 0)
                      mydelegate(i);
                  Console.WriteLine(i);

              };
            mydelegate(3);
        }
    }
}

