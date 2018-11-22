using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexators_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Indexes My = new Indexes();
            // My[0] = "string 1";
            // My[1] = "string 2";
            // My[2] = "string 3";
            // My[3] = "string 4";
            // My[4] = "string 5";
            for (int i = 0; i < 5; i++)
            {
                My[i] =string.Format( "string {0}",i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(My[i]);
            }
            Console.ReadKey();
        }
    }
}
