using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_FigureAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();

                Console.WriteLine("=== CÁLCULO DE ÁREAS ===");
                Console.WriteLine();
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Círculo");
                Console.WriteLine("4. Triángulo");
                Console.WriteLine();
                Console.Write("Seleccione una figura: ");

                string option = Console.ReadLine();

                Figure figure = null;

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese la base: ");
                        double rectangleBase = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese la altura: ");
                        double rectangleHeight = Convert.ToDouble(Console.ReadLine());

                        figure = new Rectangle(rectangleBase, rectangleHeight);
                        break;

                    case "2":
                        Console.Write("Ingrese el lado: ");
                        double side = Convert.ToDouble(Console.ReadLine());

                        figure = new Square(side);
                        break;

                    case "3":
                        Console.Write("Ingrese el radio: ");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        figure = new Circle(radius);
                        break;

                    case "4":
                        Console.Write("Ingrese la base: ");
                        double triangleBase = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese la altura: ");
                        double triangleHeight = Convert.ToDouble(Console.ReadLine());

                        figure = new Triangle(triangleBase,triangleHeight);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine();
                Console.WriteLine("Área: " + figure.GetArea());
                Console.WriteLine();

                Console.Write("¿Desea seleccionar otra figura? (S/N): ");
                string answer = Console.ReadLine();

                if (answer.ToUpper() != "S")
                {
                    continueProgram = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}