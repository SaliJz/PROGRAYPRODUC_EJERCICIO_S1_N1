using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    public class Enemy : Character
    {
        public Enemy(string name, int health, int damage) : base(name, health, damage)
        {

        }

        public override void Attack(Character target)
        {
            Console.WriteLine(Name + " se prepara para atacar.");

            base.Attack(target);
        }
    }
}