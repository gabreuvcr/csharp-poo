using System;

namespace Triangulo 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = Convert.ToDouble(Console.ReadLine());
            x.B = Convert.ToDouble(Console.ReadLine());
            x.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = Convert.ToDouble(Console.ReadLine());
            y.B = Convert.ToDouble(Console.ReadLine());
            y.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Área de X: {x.Area():F4}");
            Console.WriteLine($"Área de Y: {y.Area():F4}");
            Console.WriteLine($"Maior área: {(x.Area() > y.Area() ? "X" : "Y")}");            
        }
    }
}
