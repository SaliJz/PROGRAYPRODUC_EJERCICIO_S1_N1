using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    public class Game
    {
        private Player player;

        public void Start()
        {
            Console.WriteLine("============================");
            Console.WriteLine("     EL BOSQUE OSCURO");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.Write("Ingresa el nombre de tu héroe: ");
            string playerName = Console.ReadLine();

            player = new Player(playerName);

            Console.Clear();

            Console.WriteLine("Bienvenido, " + player.Name + ".");
            Console.WriteLine();
            Console.WriteLine("Te despiertas en medio de un bosque oscuro.");
            Console.WriteLine("A lo lejos puedes ver las ruinas de un antiguo castillo.");
            Console.WriteLine();

            FirstDecision();
        }

        private void FirstDecision()
        {
            Console.WriteLine("¿Qué deseas hacer?");
            Console.WriteLine("1. Avanzar hacia el castillo.");
            Console.WriteLine("2. Explorar el bosque.");

            string option = Console.ReadLine();

            Console.Clear();

            if (option == "2")
            {
                Console.WriteLine("Exploras el bosque y encuentras una poción.");

                player.Potions++;

                Console.WriteLine("Ahora tienes " + player.Potions + " pociones.");

                Console.WriteLine();
            }

            Console.WriteLine("Mientras avanzas aparece una criatura.");
            Console.WriteLine();

            Enemy enemy = new Goblin();

            Combat(enemy);

            if (!player.IsAlive())
            {
                GameOver();
                return;
            }

            EnterCastle();
        }

        private void EnterCastle()
        {
            Console.WriteLine();
            Console.WriteLine("Después de derrotar al Goblin llegas al castillo.");

            Console.WriteLine("Dentro encuentras un Esqueleto Guerrero protegiendo un cofre.");

            Console.WriteLine();

            Enemy enemy = new Skeleton();

            Combat(enemy);

            if (!player.IsAlive())
            {
                GameOver();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("         ¡VICTORIA!");
            Console.WriteLine("============================");

            Console.WriteLine("Abres el cofre y encuentras el tesoro perdido del reino.");

            Console.WriteLine();
            Console.WriteLine("Fin de la aventura.");
        }

        private void Combat(Enemy enemy)
        {
            while (player.IsAlive() && enemy.IsAlive())
            {
                Console.WriteLine("----------------------------");

                Console.WriteLine(player.Name + " - Vida: " + player.Health);

                Console.WriteLine(enemy.Name + " - Vida: " + enemy.Health);

                Console.WriteLine("----------------------------");

                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Usar poción");

                string option = Console.ReadLine();

                Console.WriteLine();

                if (option == "1")
                {
                    player.Attack(enemy);
                }
                else if (option == "2")
                {
                    player.Heal();
                }
                else
                {
                    Console.WriteLine("Opción incorrecta.");
                    continue;
                }

                if (enemy.IsAlive())
                {
                    Console.WriteLine();

                    enemy.Attack(player);
                }

                Console.WriteLine();
            }

            if (!enemy.IsAlive())
            {
                Console.WriteLine("¡Has derrotado a " + enemy.Name + "!");
            }
        }

        private void GameOver()
        {
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("          GAME OVER");
            Console.WriteLine("============================");

            Console.WriteLine(player.Name + " ha caído en combate.");
        }
    }
}