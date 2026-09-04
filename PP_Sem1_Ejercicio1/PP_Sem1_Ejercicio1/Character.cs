using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Sem1_Ejercicio1
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Character(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public virtual void Attack(Character target)
        {
            target.Health -= Damage;

            if (target.Health < 0)
                target.Health = 0;

            Console.WriteLine(
                Name + " ataca a " + target.Name + " y causa " + Damage + " de daño."
            );
        }
    }
}