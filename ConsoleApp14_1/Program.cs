using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            Dog dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        public override string Name { get; set; } 

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
        public Cat(string name)
        {
            Name = name;
        }
    }
    class Dog : Animal
    {
        public override string Name { get; set; } = "Собака";
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
