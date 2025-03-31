using AnimalSound;

namespace AnimalSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal("Dog", "Bark"),
                new Animal("Cat", "Meow"),
                new Animal("Cow", "Moo")
            };

            foreach(var animal in animals)
            {
                Console.WriteLine($"{animal.Type} makes sound: {animal.Sound}");
            }
        }
    }
}