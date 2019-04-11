using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class CombatMgr
    {


        public static int Fight(ref CrusaderBase attacker, ref CrusaderBase target)
        {
            target.health = target.health - attacker.damage;
            attacker.health = attacker.health - target.damage;

            if (target.health == 0 && attacker.health > 0)
            {
                
                return 1;
            }
            else 
                if (attacker.health == 0 && target.health > 0)
            {
                return -1 ;
            }
            else 
                if (target.health == 0 && attacker.health == 0)
            {
                
                return 0;
            }

            return 0;
        }
    }
}
