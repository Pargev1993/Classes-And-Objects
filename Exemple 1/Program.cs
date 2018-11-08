using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulding House = new Bulding();
           // int AreaPP;
            House.Area = 2500;
            House.Floors = 2;
            House.Occupants = 4;
            // AreaPP = House.Area / House.Occupants;
           // int AreaPP = House.Area_PerPerson();
            Console.WriteLine($"House Floors are: {House.Floors}\n House Area is: {House.Area}\n House Occupants are: {House.Occupants} \n Area for one people: {House.Area_PerPerson()}");

            Console.WriteLine();
            Bulding Office = new Bulding();
            Office.Area = 100;
            Office.Floors = 1;
            Office.Occupants = 10;
           // AreaPP = Office.Area_PerPerson();
            Console.WriteLine($"Office Floors are: {Office.Floors}\n Office Area is: {Office.Area}\n Office Occupants are: {Office.Occupants}\n Area for one people: {Office.Area_PerPerson()}");
            // Office.AreaPerPerson();
            Console.WriteLine(new string('_',50));
           if (House.Area_PerPerson()>Office.Area_PerPerson())
                Console.WriteLine($"In the building House more space for each person");
            Console.ReadLine();
            
        }
    }
}
