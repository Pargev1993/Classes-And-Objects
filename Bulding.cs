using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bulding
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов

        public void AreaPerPerson()
        {
            Console.WriteLine($"Area for one people: {Area/Occupants}");
        }

    }

}
