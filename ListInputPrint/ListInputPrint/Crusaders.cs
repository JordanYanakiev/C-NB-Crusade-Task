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

        public void Talk()
        {
            Console.WriteLine("my nAme is natali");
        }

    }

    public class Nate:CrusaderBase     //Nate class inheriting the CrusaderBase
    {
        public Nate()     //Empty constructor
        { }

        public Nate(string Name)    //Constructor with one parameter
        {
            this.name = Name;
        }

        public void Talk()
        {
            Console.WriteLine("I am Nate!");
        }

    }
}
