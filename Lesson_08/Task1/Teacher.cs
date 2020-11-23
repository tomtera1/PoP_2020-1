using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_01
{
    public class Teacher : Person
    {
        private string subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
