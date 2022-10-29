
// 9) Create one example for hierarchical inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Birds birds = new Birds();
            birds.Display();

            Fish fish = new Fish();
            fish.Display();

            Humans humans = new Humans();
            humans.Display();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Name(string name)
        {
            Console.WriteLine("This is a " + name);
        }
    }

    class Birds : Animal
    {
        public void CanFly(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("Yes..! It can fly.\n");
            }
            else
            {
                Console.WriteLine("Oh..! It cannot fly.\n");
            }
        }

        public void Display()
        {
            Animal animal = new Animal();
            animal.Name("Crow");
            CanFly(true);
        }
    }

    class Fish : Animal
    {
        public void CanSwim(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("Yes..! It can swim.\n");
            }
            else
            {
                Console.WriteLine("Oh..! It cannot swim.\n");
            }
        }

        public void Display()
        {
            Animal animal = new Animal();
            animal.Name("White Shark");
            CanSwim(true);
        }
    }

    class Humans : Animal
    {
        public void Display()
        {
            Console.WriteLine("YES.! Humans are Social Animals.");
        }
    }
}
