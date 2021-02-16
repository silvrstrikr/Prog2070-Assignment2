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
using Assignment2_Prog2070;
using NUnit.Framework;

namespace Assignment2Tests
{
    [TestFixture]
    public class RectangleTest
    {
        #region TestGetLength

        [Test]
        public void RectangleTestGetLength_1()
        {
            //Arrange
            Rectangle r = new Rectangle();

            int expected = 1;

            //Act
            int actual = r.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void RectangleTestGetLength_10_2_20_20()
        {
            //Arrange
            Rectangle r = new Rectangle(10, 2);

            r.SetLength(20);

            int expected = 20;

            //Act
            int actual = r.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        
        [Test]
        public void RectangleTestGetLength_1_2000_200_20_200()
        {
            //Arrange
            Rectangle r = new Rectangle(1, 2000);
            r.SetLength(200);
            r.SetWidth(20);

            int expected = 200;

            //Act
            int actual = r.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region TestGetWidth

        [Test]
        public void RectangleTestGetWidth_1()
        {
            //Arrange
            Rectangle r = new Rectangle();

            int expected = 1;

            //Act
            int actual = r.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        
        [Test]
        public void RectangleTestGetWidth_10_20_20()
        {
            //Arrange
            Rectangle r = new Rectangle(10, 20);

            int expected = 10;

            //Act
            int actual = r.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        
        [Test]
        public void RectangleTestGetWidth_1_2000_2000()
        {
            //Arrange
            Rectangle r = new Rectangle();
            r.SetLength(2000);
            r.SetWidth(1);

            int expected = 1;

            //Act
            int actual = r.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region TestSetLength

        [Test]
        public void RectangleTestSetLength_12_12()
        {
            //Arrange
            Rectangle r = new Rectangle();

            int expected = 12;

            //Act
            int actual = r.SetLength(12);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void RectangleTestSetLength_10_20_25_25()
        {
            //Arrange
            Rectangle r = new Rectangle(10, 20);

            int expected = 25;

            //Act
            int actual = r.SetLength(25);

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        
        [Test]
        public void RectangleTestSetLength_1_2000_9_9()
        {
            //Arrange
            Rectangle r = new Rectangle();
            r.SetWidth(1);
            r.SetLength(2000);

            int expected = 9;

            //Act
            int actual = r.SetLength(9);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region TestSetWidth

        [Test]
        public void RectangleTestSetWidth_25_25()
        {
            //Arrange
            Rectangle r = new Rectangle();

            int expected = 25;

            //Act
            int actual = r.SetWidth(25);

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        
        [Test]
        public void RectangleTestSetWidth_10_20_23_23()
        {
            //Arrange
            Rectangle r = new Rectangle(10, 20);

            int expected = 23;

            //Act
            int actual = r.SetWidth(23);

            //Assert
            Assert.AreEqual(expected, actual);
        }        
        
        [Test]
        public void RectangleTestSetWidth_1_2000_2001_2001()
        {
            //Arrange
            Rectangle r = new Rectangle();
            r.SetWidth(1);
            r.SetLength(2000);

            int expected = 2001;

            //Act
            int actual = r.SetWidth(2001);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region TestGetPerimeter

        [Test]
        public void RectangleTestGetPerimeter_4()
        {
            //Arrange
            Rectangle r = new Rectangle();

            int expected = 4;

            //Act
            int actual = r.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RectangleTestGetPerimeter_30_20_100()
        {
            //Arrange
            Rectangle r = new Rectangle(30,20);

            int expected = 100;

            //Act
            int actual = r.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RectangleTestGetPerimeter_1_999_2000()
        {
            //Arrange
            Rectangle r = new Rectangle();
            r.SetLength(1);
            r.SetWidth(999);

            int expected = 2000;

            //Act
            int actual = r.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region TestGetArea

        [Test]
        public void RectangleTestGetArea_1()
        {
            //Arrange
            Rectangle r = new Rectangle();

            int expected = 1;

            //Act
            int actual = r.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RectangleTestGetArea_14_21_294()
        {
            //Arrange
            Rectangle r = new Rectangle(14, 21);

            int expected = 294;

            //Act
            int actual = r.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RectangleTestGetArea_43_2_86()
        {
            //Arrange
            Rectangle r = new Rectangle();
            r.SetLength(43);
            r.SetWidth(2);
            int expected = 86;

            //Act
            int actual = r.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion


    }
}
