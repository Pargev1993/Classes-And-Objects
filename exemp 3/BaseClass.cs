using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemp_3
{
   abstract class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Method 2");
        }
         abstract public void AbstractMethod3();
    }
}
