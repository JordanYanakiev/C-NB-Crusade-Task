using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class CrusadersFactory
    {
        enum CrusaderTypes {none, crusaderNate, crusaderNatali, crusaderKuori };

        //Method for creating crusader Nate
        public static void CreateNate(string name, int level, int health, int damage)
        {
            Nate NateDragon = new Nate(name, level, health, damage);
            //Print the info for the new object NateDragon
            Console.WriteLine(NateDragon.name + " " + NateDragon.level + " "  + NateDragon.health + " " + NateDragon.damage);
        }

        //Method for creating crusader Natali
        public void CreateNatali(string name, int level, int health, int damage)
        {
            Natali crusaderNatali = new Natali(name, level, health, damage);
        }

        //Method or creating crusader Kuori
        public void CreateKuori()
        {
            Kuori crusaderKuori = new Kuori();
        }
    }
}
