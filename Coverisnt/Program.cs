using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coverisnt
{
    public interface IAnimal
    {
        void voice();
    }
    public class Dog:IAnimal
    {
        public void voice()
        {
            Console.WriteLine("Voise");
        }
        public void jump()
        {
            Console.WriteLine("Jump");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].voice();
                dogs[i].jump();
            }
            Console.WriteLine();
            IAnimal[] animals = dogs;
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].voice();
            }
            Console.WriteLine();
            dogs = (Dog[])animals;
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].voice();
                dogs[i].jump();
            }
            Console.ReadKey();

        }
    }
}
