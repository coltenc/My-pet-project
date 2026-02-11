using System;
using System.Collections.Generic;
using System.Text;

namespace My_pet_project
{
    internal class Fish : Animals
    {
        public Fish(string food, string color, string name) : base(food, color, name)
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("The Fish is eating.");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("The Fish says, Blub.");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("The Fish is sleeping, ZZZZZZZZZZZZZZZZzzzzzzzzzzzzzz.");
        }
    }
}
