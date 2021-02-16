using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Prog2070
{
    class Rectangle
    {
        private int width;

        private int length;

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            return this.length = length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            return this.width = width;
        }

        public int GetPerimeter()
        {
            return length * 2 + width * 2;
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
