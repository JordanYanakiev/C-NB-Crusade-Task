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
        public void CreateNate(string name, int level, int health, int damage)
        {
            Nate crusaderNate = new Nate(name, level, health, damage);
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
