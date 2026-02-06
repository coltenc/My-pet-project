using System.Diagnostics.Tracing;
using System.Dynamic;

namespace My_Pet_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Dog = new Dog("Dog Food", "Brown", "Buddy");
            var Cat = new Cat("Cat Food", "Black", "Whiskers");
            var Fish = new Fish("Fish Food", "Gold", "Goldie");

            var pets = new Animals[] { Dog, Cat, Fish };

            foreach (var item in pets)
            {
                Console.WriteLine("");
            }
        }
    }
}
