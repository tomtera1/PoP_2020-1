﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_01
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old");
        }
    }
}