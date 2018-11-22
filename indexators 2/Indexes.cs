using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexators_2
{
    class Indexes
    {
        private string[] Array =new string[5];
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Array.Length)
                    return Array[index];
                else
                    return "error";
            }
            set
            {
                if (index >= 0 && index < Array.Length)
                    Array[index] = value;
                else
                    Console.WriteLine("Error");

            }
        }

    }
}
