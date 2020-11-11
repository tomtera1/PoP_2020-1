using Lesson_05.MyAnimals;
using System;

namespace Lesson_05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task02();
        }

        private static void Task02()
        {
            Person person1 = new Person("John Smith", 22);

            Person person2 = new Person("Jane Smith", 20, "jane@smith.com");

            Person person3 = new Person("Ivan", 20, "my@email");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
        }

        private static void Task01()
        {
            Dog dog = new Dog
            {
                Name = "Sharo",
                Breed = "Street Universal"
            };

            dog.Bark();
        }

        private static void CreateCats()
        {
            Animal animal = new Animal();

            Cat myCat = new Cat("Maria", "Stefania");

            Cat myCat1 = new Cat("Homeless cat");

            Cat myCat2 = new Cat()
            {
                Name = "Maria",
                Owner = "Stefania"
            };

            Console.WriteLine($"Hello {myCat.Name}!");
        }
    }
}