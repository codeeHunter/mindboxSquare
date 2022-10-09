using System;
using NUnit.Framework;

namespace Square.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Triangle_5_23_51_false()
        {
            double a = 5;
            double b = 23;
            double c = 51;

            double actualSquare = Square.Triangle(a, b, c);

            Assert.IsNaN(actualSquare);
        }

        [Test]
        public void Triangle_3_4_5_6_and_rectangular()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            double expectedSquare = 6;

            double actualSquare = Square.Triangle(a, b, c);

            bool flag = actualSquare == expectedSquare;

            Assert.True(flag);
        }

        [Test]
        public void Triangle_2_2_3_1_98431()
        {
            double a = 2;
            double b = 2;
            double c = 3;

            double expectedSquare = 2;
            double actualSquare = Square.Triangle(a, b, c);
           
            
            bool flag = expectedSquare == Math.Round(actualSquare);
            
            Assert.True(flag);
        }
        [Test]
        public void Circle_2_13()
        {
            double r = 2;

            double expectedSquare = 13;
            double actualSquare = Square.Circle(r);
            
            Assert.AreEqual(expectedSquare, Math.Round(actualSquare));
        }
        [Test]
        public void Circle_9_254()
        {
            double r = 9;

            double expectedSquare = 254;
            double actualSquare = Square.Circle(r);
            
            Assert.AreEqual(expectedSquare, Math.Round(actualSquare));
        }
    }
}