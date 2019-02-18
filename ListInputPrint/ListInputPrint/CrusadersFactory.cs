using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class CrusadersFactory
    {
        enum Crusaders {none, crusaderNate, crusaderNatali, crusaderKuori };
        public void CreateNate()
        {
            Nate crusaderNate = new Nate("Nate", 200, 1900, 250);
        }

        public void CreateNatali()
        {
            Natali crusaderNatali = new Natali("Natali", 200, 1500, 300);
        }

        public void CreateKuori()
        {
            Kuori crusaderKuori = new Kuori();
        }
    }
}
