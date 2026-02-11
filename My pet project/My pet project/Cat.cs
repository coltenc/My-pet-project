using My_pet_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_pet_project
{
    internal class Cat : Animals
    {
        public Cat(string food, string color, string name) : base(food, color, name)
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("The Cat is eating.");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("The Cat says, Meow.");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("The Cat is sleeping, ZZZZZZZZZZZZZZZZzzzzzzzzzzzzzz.");
        }
    }
}
