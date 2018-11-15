using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 namespace propiska1
{
    namespace Lukashin
    {
        namespace Borisovich
        {

            class Vitali
            {
              public static void Run()
                {
                    Console.WriteLine("Vitali can run!");
                }
            }
        }
    }
}

namespace propiska2
{
    namespace Lukashin
    {
        namespace Borisovich
        {

             class Vitali
            {
              public  static void Run()
                {
                    Console.WriteLine("Vitali can not run!");
                }
            }
        }
    }
}
class Program
{
    static void Main()
    {
        propiska1.Lukashin.Borisovich.Vitali.Run();
        Console.ReadKey();
    }
}