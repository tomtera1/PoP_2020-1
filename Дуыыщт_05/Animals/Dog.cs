using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05.MyAnimals
{
    public class Dog
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
