using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. New line \nNew outher line \"Line\"");
            Console.WriteLine("2.New\touther\tline");
            Console.WriteLine("3.New outher line line line \routher");
            Console.WriteLine("4.New outher \aline ");
            Console.WriteLine("5.New outher  \\n \nline ");
            Console.WriteLine("6.File road is D:\\film\\...");
            Console.WriteLine(@"7.File 

road is D:\film\...\n \r \n \a");
            Console.WriteLine("8. New outher line" + Environment.NewLine + "\"Line\"");
            Console.WriteLine("9.The name machinery :" + Environment.MachineName);
            Console.WriteLine("10.The processor count:" + Environment.ProcessorCount);
            Console.WriteLine("11.The user name :" + Environment.UserName);
            Console.WriteLine("12.The versia of mashine :" + Environment.Version);
            Console.WriteLine("13.The versia of program :" + Environment.OSVersion);
            Console.WriteLine("C format {0:C}", 5665.166);//Currency
            Console.WriteLine("D9 format {0:D9}", 5665);//Decimal number
            Console.WriteLine("E format {0:E}", 5665.166);//Exponential
            Console.WriteLine("F3 format {0:F3}", 9999.9999);//Fixed comma
            Console.WriteLine("G format {0:G}", 5665.166);//Are common
            Console.WriteLine("N format {0:N}", 5665.166);//Numeric
            Console.WriteLine("P format {0:P}", 5665.166);//Percent
            Console.WriteLine("R format {0:R}", 5665.166);//Transmission
            Console.WriteLine("X format {0:X}", 5665);//Hexadecimal
            Console.ReadKey();
        }
    }
}
