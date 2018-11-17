using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemp_3
{
    class concretDirivedClass:BaseClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("Dirived Class Virtual Method");
        }
        public override void AbstractMethod3()
        {
            Console.WriteLine("Diravied Class Abstract method");
        }
    }
}
