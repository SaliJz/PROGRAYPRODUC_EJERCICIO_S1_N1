using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Start();

            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");

            Console.ReadKey();
        }
    }
}