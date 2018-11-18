using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_2_Use_of_parameters
{
    class CheckNum
    {
        public bool IsPrim(int x)
        {
            if (x <= 1)
                return false;
            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0)
                    return false;

            return true;
        }
    }
}
