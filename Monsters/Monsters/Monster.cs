using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class Monster
    {
        public string name;
        public int hp;
        public int damage;

        public Monster(string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
            describe();
        }
        public void describe()
        {
            Console.WriteLine("Questo è " + name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("DAMAGE: " + damage);
        }

    }
}
