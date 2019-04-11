using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class CrusadersFactory : CrusaderBase
    {
        public static Nate crusaderNate;
        public static Natali crusaderNatali;
        public static Kuori crusaderKuori;

        enum CrusaderTypes {none, NateDragon, crusaderNatali, crusaderKuori };
      
        
        //Method for creating crusader Nate
        public static Nate CreateNate(string name, int level, int health, int damage)
        {
             crusaderNate = new Nate(name, level, health, damage);
            
            //Print the info for the new object NateDragon
            //Console.WriteLine(NateDragon.name + " " + NateDragon.level + " "  + NateDragon.health + " " + NateDragon.damage);
            return crusaderNate;
        }

        
        //Method for creating crusader Natali
        public static Natali CreateNatali(string name, int level, int health, int damage)
        {
            crusaderNatali = new Natali(name, level, health, damage);

            return crusaderNatali;
        }

        //Method or creating crusader Kuori
        public static Kuori CreateKuori(string name, int level, int health, int damage)
        {
            crusaderKuori = new Kuori(name, level, health, damage);

            return crusaderKuori;
        }
    }
}
