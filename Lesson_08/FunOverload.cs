using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08
{
    internal class FunOverload
    {
        public string name;

        public void SetName(string last)
        {
            name = last;
        }

        public void SetName(string first, string last)
        {
            name = first + " " + last;
        }
    }
}
