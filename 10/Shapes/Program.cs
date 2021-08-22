using System;
using System.Collections.Generic;
using Shapes.Entities;
using Shapes.Entities.Enums;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numShapes = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numShapes; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");

                char kindShape;
                do
                {
                    Console.Write("Rectangle or Circle (r/c)? ");
                    kindShape = Char.Parse(Console.ReadLine().Trim().ToLower());
                } while (kindShape != 'r' && kindShape != 'c');

                string colorString;
                do
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    colorString = Console.ReadLine().Trim();
                } while (colorString != "Black" && colorString != "Blue" && colorString != "Red");
                Color color = Enum.Parse<Color>(colorString);

                if (kindShape == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = Double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
                else
                {
                    Console.Write("Width: ");
                    double width = Double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = Double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                }
            }

            Console.WriteLine("\nSHAPES AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area():F2}");
            }

        }
    }
}
