using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate Mydelegat1 Mydelegate (Mydelegate2 mydelegate2, Mydelegate3 mydelegate3);
    public delegate string Mydelegat1();
    public delegate string Mydelegate2();
    public delegate string Mydelegate3();
    class Program
    {
        public static Mydelegat1 Method(Mydelegate2 mydelegate2,Mydelegate3 mydelegate3)
        {
            return delegate { return mydelegate2.Invoke() + mydelegate3.Invoke(); };
        }
        public static string Method1() { return "Hello"; }
        public static string Method2() { return "Hello2"; }
        static void Main(string[] args)
        {
            Mydelegate mydelegate = new Mydelegate(Method);
            Mydelegat1 mydelegat1 = mydelegate.Invoke(new Mydelegate2(Method1), new Mydelegate3(Method2));
            mydelegat1.Invoke();
        }
    }
}
