using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pet_Project
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
