using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string describe()
        {
            string output ="Questo è " + name + "\r\n";
            output +="HP: " + hp + "\r\n";
            output += "DAMAGE: " + damage+"\r\n";

            return output;
        }
        public void describe(TextBox t)
        {
            t.Text = describe();
        }

    }
}
