using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    public class Goblin : Enemy
    {
        public Goblin() : base("Goblin", 40, 10)
        {

        }

        public override void Attack(Character target)
        {
            Console.WriteLine("El Goblin ataca rápidamente con su daga.");

            target.Health -= Damage;

            if (target.Health < 0) target.Health = 0;

            Console.WriteLine("Recibes " + Damage + " de daño.");
        }
    }
}