using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class Kuori:CrusaderBase
    {
        public Kuori ()
        { }

        public Kuori (string Name)
        {
            Name = this.name;
        }

        public Kuori (string Name, int Level, int Health)
        {
            Name = this.name;
            Level = this.level;
            Health = this.health;
        }

        public Kuori(string Name, int Level, int Health, int Damage)
        {
            Name = this.name;
            Level = this.level;
            Health = this.health;
            Damage = this.damage;
        }

        public override void UseSpecialAbility(ref CrusaderBase target)  //This implements the special ability of each crusader
        {
            target.health += 25;
        }
    }
}
