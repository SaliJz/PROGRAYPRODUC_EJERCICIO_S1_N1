using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    public class Skeleton : Enemy
    {
        public Skeleton() : base("Esqueleto Guerrero", 60, 15)
        {

        }

        public override void Attack(Character target)
        {
            Console.WriteLine("El Esqueleto balancea su espada oxidada.");

            target.Health -= Damage;

            if (target.Health < 0) target.Health = 0;

            Console.WriteLine("Recibes " + Damage + " de daño.");
        }
    }
}