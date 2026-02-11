using System;
using System.Collections.Generic;
using System.Text;

namespace My_pet_project
{
    internal class Dog : Animals
    {

        public Dog(string food, string color, string name) : base(food, color, name)
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("The Dog is eating.");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("The Dog says, Woof.");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("The Dog is sleeping, ZZZZZZZZZZZZZZZZzzzzzzzzzzzzzz.");
        }
    }
}
