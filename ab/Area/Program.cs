using System;

namespace Area 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            float a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
            float pi = 3.14159f;

            string[] values = Console.ReadLine().Split(' ');
            a = float.Parse(values[0]);
            b = float.Parse(values[1]);
            c = float.Parse(values[2]);

            triangulo = (a * c) / 2;
            circulo = pi * c * c;
            trapezio = ((a + b) * c) / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"\nTRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}
