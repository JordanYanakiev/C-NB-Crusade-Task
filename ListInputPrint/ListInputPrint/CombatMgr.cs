using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class CombatMgr
    {
        private CrusaderBase attacker;
        private CrusaderBase target;

        public CrusaderBase Attacker
        {
            get { return attacker;  }
            set { attacker = value;  }
        }

        public CrusaderBase Target
        {
            get { return target; }
            set { target = value; }
        }

        public CombatMgr(CrusaderBase attacker, CrusaderBase target)
        {
            this.attacker = attacker;
            this.target = target;
        }

        public static void  Fight( CrusaderBase attacker,  CrusaderBase target)
        {
            target.health = target.health - attacker.damage;
            attacker.health = attacker.health - target.damage;

            if (target.health == 0 && attacker.health > 0)
            {
                Console.WriteLine("{0} Wins!", attacker.name);
               // return 1;
            }
            else 
                if (attacker.health == 0 && target.health > 0)
            {
                Console.WriteLine("{0} Wins!", target.name);
                //return -1 ;
            }
            else 
                if (target.health == 0 && attacker.health == 0)
            {
                Console.WriteLine("{0}  and {1} Died Both!", attacker.name, target.name);
                //return 0;
            }

           // return 0;
        }
    }
}
