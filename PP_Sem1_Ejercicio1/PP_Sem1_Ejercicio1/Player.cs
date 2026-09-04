using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    public class Player : Character
    {
        public int Potions { get; set; }

        public Player(string name) : base(name, 100, 20)
        {
            Potions = 2;
        }

        public void Heal()
        {
            if (Potions > 0)
            {
                Health += 30;

                if (Health > 100) Health = 100;

                Potions--;

                Console.WriteLine("Usaste una poción.");
                Console.WriteLine("Vida actual: " + Health);
                Console.WriteLine("Pociones restantes: " + Potions);
            }
            else
            {
                Console.WriteLine("No tienes pociones.");
            }
        }

        public override void Attack(Character target)
        {
            Console.WriteLine("¡" + Name + " usa su espada!");

            base.Attack(target);
        }
    }
}