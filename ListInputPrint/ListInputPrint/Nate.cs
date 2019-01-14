using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    public class Nate : CrusaderBase     //Nate class inheriting the CrusaderBase
    {
        public Nate()     //Empty constructor
        { }

        public Nate(string Name)    //Constructor with one parameter
        {
            this.name = Name;
        }

        public Nate(string Name, int Level, int Health)    //Constructor with three parameters
        {
            this.name = Name;
            this.level = Level;
            this.health = Health;
        }
        public Nate(string Name, int Level, int Health, int Damage)    //Constructor with three parameters
        {
            this.name = Name;
            this.level = Level;
            this.health = Health;
            this.damage = Damage;
        }

        public Nate(string Name, int Level) : base (Name, Level)
        {

        }


        public void Talk()           //Method that imitates Nate's speech
        {
            Console.WriteLine("I am Nate!");
        }

    }
}
