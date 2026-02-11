namespace My_pet_project
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
                    item.Speak();
                    item.Eat();
                    item.Sleep();
                    Console.WriteLine("");
                }
        } 
    }
}
