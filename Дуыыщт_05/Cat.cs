using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    public class Cat : Animal
    {
        private string name;

        public Cat(string name, string owner)
        {
            Name = name;
            Owner = owner;
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Can must have name!!!");
                }
                name = value;
            }
        }

        public string Owner
        {
            get;
            set;
        }

        public void SayMiau()
        {
            Console.WriteLine("Miauuuuuuu!");
        }
    }
}