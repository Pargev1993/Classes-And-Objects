using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate
{
    class Account
    {
        private int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        public void Put(int sum)
        {

        }
        
        public void WithDraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                Console.WriteLine("Your Balans:" + _sum);
            }
            else
                Console.WriteLine("your Balans not so much ");
            Console.WriteLine(new string('-', 30));
        }
    }
    class Program
    {
        private delegate void Message();

        private delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.Put(100);
            account.WithDraw(100);
            account.WithDraw(150);
            Message message;
            message = Display;
            message += Print;
            message += StringOutput;
            message.Invoke();
            Operation operation;
            operation = AddOfNumbers;
            operation(5, 8);
            operation += Sum;
            operation += OutputOfNumbers;
            operation(3, 8);


        }

        private static void Display()
        {

            Console.WriteLine("Hello!");
            Console.WriteLine(new string('-', 30));
        }
        private static void Print()
        {
            int x = 0;
            x++;
            Console.WriteLine(x);
            Console.WriteLine(new string('-', 30));
        }
        private static int AddOfNumbers(int x, int y)
        {
            x++;
            y += x;
            int z = y + x;
            Console.WriteLine(z);
            Console.WriteLine(new string('-', 30));
            return z;
        }
        private static int Sum(int x, int y)
        {
            Console.WriteLine(x - y);
            Console.WriteLine(new string('-', 30));
            return x - y;
        }
        private static void StringOutput()
        {
            Stack<string> Letters = new Stack<string>();
            Letters.Push("o");
            Letters.Push("l");
            Letters.Push("e");
            Letters.Push("h");
            string word = null;
            word += Letters.Pop();
            word += Letters.Pop();
            word += Letters.Peek();
            word += Letters.Pop();
            word += Letters.Pop();
            Console.WriteLine(word);
            Console.WriteLine(new string('-', 30));
        }
        private static int OutputOfNumbers(int x, int y)
        {
            while (x < 10)
            {
                ++x;
                x *= x;
                y += x;
            }
            Console.WriteLine(y);
            Console.WriteLine(new string('-', 30));
            return y;
        }
       



    }
}
