using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    //Base Crusader Class
    public class CrusaderBase
    {
        public string name = string.Empty;
        public int level = 0;
        public int health = 0;

        //Cosnstructors for the class CrusaderBase
        public CrusaderBase()    // Empty constructor
        { }

        public CrusaderBase(string Name)    //Constructor with one parameter
        {
            this.name = Name;
        }

        public CrusaderBase(string Name, int Level)    //Constructor with two parameters
        {
            this.name = Name;
            this.level = Level;
        }

        public CrusaderBase(string Name, int Level, int Health)    //Constructor with three parameters
        {
            this.name = Name;
            this.level = Level;
            this.health = Health;
        }

        public void Talk(string smthToSay)      //Method that imitates crusaders speech
        {
            Console.WriteLine(smthToSay);
        }

        public virtual void Hit( ref CrusaderBase crusaderbase )              // Method for imitating hit from the crusader
        {
            throw new Exception();
        }

    }
}
