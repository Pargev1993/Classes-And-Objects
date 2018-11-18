using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _string_exem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = " Madam I am Adam! ";

            Console.WriteLine(s.Contains('M'));// stugum e m tari parunakutyun@ textum
            Console.WriteLine(s.Length);//s-i erkarutyun@
            Console.Write(s.PadLeft(29,'*'));//Avelacnum e texti qanak + avelacac tverin *
            Console.WriteLine(new string('*', 13));
            Console.WriteLine(s.Remove(10, 5));//jjnum en 10-rd toxic sksac 5 hat sinfol
            Console.WriteLine(s.Replace(' ', '+'));//sinvoli poxarinum e +
            Console.WriteLine(s.Replace("Madam","MADAM"));//poxarinum e hin sinvolner@ nor sivolnerov
            Console.WriteLine(s.ToLower());//bolor tarer@ mecatar
            Console.WriteLine(s.ToUpper());//bolor tarer@ poqratar
            Console.WriteLine(s.Trim());//jnjum e skzbic ev verjic avel probelner@
            Console.ReadKey();
            //Static Strings
            string ss = string.Concat(s, "!!!!!!", s, "999");//concotenaciaya anum bolor@ mek toxi vra
            Console.WriteLine(ss);
            ss = string.Copy(s);// s text@ copy e anum veragrelov ss-in
            Console.WriteLine(ss);
            ss = string.Empty;//avelacnum e datark taracq
            Console.WriteLine(s[10]);
            String l = string.Copy(s)+"!!" ;//copyin avelacnum e sinvolner
            Console.WriteLine(l);
            // Console.WriteLine(s==l);
            Console.WriteLine(s.Equals(l));//stugum e s havasar e ardyoq l-in
            Console.WriteLine(s.CompareTo(l));//hashvum e s-i ev l-i sinvolneri qanaki tarberutyun@
            Console.WriteLine(Object.ReferenceEquals(s, l));//stugum e ardyoq Hipum S-@ ev l-@ nuynnen nuyn hxum@ unen te voch
            ss = s;
            Console.WriteLine(object.ReferenceEquals(s,ss));
            int age = 25;
            int work = 10;
            string sss = string.Format("ypu work {0},{1}", age, work);
            Console.WriteLine(sss);
            Console.ReadKey();
        }
    }
}
