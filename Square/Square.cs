using System;

namespace Square
{
    public static class Square
    {
        public static double Triangle(double a, double b, double c)
        {
            double P = 1;
            double S = 0;
            
            if (a == 0 || b == 0 || c == 0)
            {
                return 0;
            }

            if (a > b && a > c)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.Write("Треугольник прямоугольный \n");
                }
            } else if (b > a && b > c)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                {
                    Console.Write("Треугольник прямоугольный \n");
                }
            } else if (c > a && c > b)
            {
                if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                {
                    Console.Write("Треугольник прямоугольный \n");
                }
            }

            if (a + b > c || a + c > b || c + b > a)
            {
                P = (a + b + c) / 2;
                S = Math.Pow((P * (P - a) * (P - b) * (P - c)), 0.5);
            }
            else
            {
                return 0;
            }

            return S;
        }

        public static double Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}