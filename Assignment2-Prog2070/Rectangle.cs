using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Prog2070
{
    public class Rectangle
    {
        public Rectangle()
        {
            width = 1;
            length = 1;
        }
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

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
