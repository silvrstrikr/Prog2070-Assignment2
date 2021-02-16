/*
 * Alan Beals
 * Assignment 2
 * Prog 2070 - Quality Assurance
 * 8658171
 * 2021-02-16
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Prog2070
{
    public class Rectangle
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Rectangle()
        {
            width = 1;
            length = 1;
        }

        /// <summary>
        /// constructor with passed values
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        private int width;

        private int length;
        /// <summary>
        /// returns length
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return length;
        }
        /// <summary>
        /// returns and sets the length
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public int SetLength(int length)
        {
            return this.length = length;
        }
        /// <summary>
        /// returns width
        /// </summary>
        /// <returns></returns>
        public int GetWidth()
        {
            return width;
        }
        /// <summary>
        /// returns and sets the width
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public int SetWidth(int width)
        {
            return this.width = width;
        }
        /// <summary>
        /// returns the perimeter using the dimensions
        /// </summary>
        /// <returns></returns>
        public int GetPerimeter()
        {
            return (length + width) * 2;
        }
        /// <summary>
        /// returns the area using the current dimensions
        /// </summary>
        /// <returns></returns>
        public int GetArea()
        {
            return length * width;
        }
    }
}
