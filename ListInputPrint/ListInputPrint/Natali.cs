using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    public class Natali:CrusaderBase   //Natali class inheriting the CrusaderBase class
    {
        
        public Natali()  //Empty constructor
        { }

        public Natali(string Name)  //Constructor with one parameter
        {
            this.name = Name;
        }

        public Natali (string Name, int Level, int Health)    //Constructor with three parameters
        {
            this.name = Name;
            this.level = Level;
            this.health = Health;
        }

        public Natali(string Name, int Level, int Health, int Damage)    //Constructor with three parameters
        {
            this.name = Name;
            this.level = Level;
            this.health = Health;
            this.damage = Damage;
        }

        public void Talk()          //Method that imitates Natali's speech
        {
            Console.WriteLine("my nAme is natali");
        }

        public override void Hit(ref CrusaderBase target)
        {
            target.health -= this.damage;

        }

    }
}
