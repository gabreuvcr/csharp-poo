using System;

namespace Triangulo 
{
    class Triangulo 
    {
        public double A, B, C;

        public double Area() 
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }
}
