using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08
{
    internal class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }

    // Derived class
    internal class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

}
