using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _char
{
    class Program
    {
        static void Main(string[] args)
        {
            // string str = null; ;
            // char ch = 'A';
            // str += ch;  //str = str + ch;   // str = Convert.ToString(ch);
            // Console.WriteLine(str);
            // Console.WriteLine(char.IsPunctuation('!'));
            // Console.WriteLine(char.IsPunctuation('>'));
            // Console.ReadKey();
            //char Number;

            // *******************************************

            //Console.WriteLine("Enter track  number!");
            //while (true)
            //{
            //    try
            //    {
            //        Number = char.Parse(Console.ReadLine());

            //        if (char.IsDigit(Number))
            //        {
            //            Console.WriteLine("You have a track number: " + Number);
            //            break;
            //        }

            //        else
            //            Console.WriteLine("Please Ender number!");
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Ender number form 0-9!");
            //    }
            //}
            //********************************************************************

            char first, second;
            Console.Write("Enter first number: ");
            first = char.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = char.Parse(Console.ReadLine());
            Console.WriteLine("Simvole quantity in "+first+" and "+second +" = "+second.CompareTo(first));
            Console.ReadKey();
        }
    }
}
