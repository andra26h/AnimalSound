using AnimalSound;

namespace AnimalSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Cat());
            animals.Add(new Cow());
            animals.Add(new Cow());

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetType() + " makes sound: " + animal.GetSound());
            }

            Console.ReadKey();
        }
    }
}