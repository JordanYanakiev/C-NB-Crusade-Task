﻿using System;
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
        public int damage = 0;
        public bool IsAlive = true;
        public string crusaderType;
        public DateTime coolDown;

        public int Damage
        {
            get { return damage; }
            set { damage = value;  }
        }

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

        public CrusaderBase(string Name, int Level, int Health, int Damge)    //Constructor with four parameters
        {
            this.name = Name;
            this.level = Level;
            this.health = Health;
            this.damage = Damage;
        }

        public void Talk(string smthToSay)      //Method that imitates crusaders speech
        {
            Console.WriteLine(smthToSay);
        }

        public virtual void Hit( ref CrusaderBase target )              // Method for imitating hit from the crusader
        {
            health += 1; 
            if (health == 0)
            {
                Die();
            }
            throw new Exception();
        }

        public virtual void Die()      // Method immitating the death of a hero
        {
            IsAlive = false;
        }

        public virtual void UseSpecialAbility(ref CrusaderBase target)  //This implements the special ability of each crusader
        {
            DateTime coolDown;
            int coolDownSpecialInterval;
        }
    }
}
