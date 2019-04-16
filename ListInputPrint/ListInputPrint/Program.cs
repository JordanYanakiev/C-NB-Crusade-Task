/*
 

 1. Сложи cooldown на Special Ability-то. 
    В базовия клас.
    
 2. Сложи cooldownSpecial от тип DateTime.
 
 3. Нека има и cooldownSpecialInterval 
    от тип int - това ще е в милисекунди.

 4. Нека енума се казва да е CrusaderTypes
    и нека базовия клас има такова поле, 
    от тип CrusaderTypes примерно CrusaderType.

 5. Нека има и друг клас CrusadersMgr.cs
    този вече ще е статичен клас
    вътре сложи само един List<CrusaderBase> crusaders
    този лист нека е публиен и статичен

 6. Нека има нов клас CombatMgr
    да има метод Fight(ref crusader1, ref crusader2).
    Да ги сбива, и да връща -1 крусейдъра победител

 7. Направи ново пропърти на CrusaderBase, от тип string
    и в конструктора на всеки crusader да се попълва с 
    произволен стринг от цифри с дължина 10

 
 */







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class Program
    {

        ////Base Crusader Class
        //public class CrusaderBase
        //{
        //    public string name = null;
        //    public int level = 0;
            
        //    //Cosnstructors for the class CrusaderBase
        //    public CrusaderBase()
        //    { }

        //    public CrusaderBase(string Name, int Level)
        //    {
        //        this.name = Name;
        //        this.level = Level;
        //    }
        //}





        //Method to count the positive and the negative numbres
        static bool CountDigits(ref List<int> myList, out int counterPositive, out int counterNegative)
        {
            int listLength = myList.Count;
            bool flag = false;
            counterPositive = 0;
            counterNegative = 0;

            for (int i = 0; i < listLength; i++)
            {
                if (myList[i] > 0)
                {
                    counterPositive++;
                }
                else
                    if (myList[i] < 0)
                    {
                      counterNegative++;
                    }
            }

            if (counterPositive == counterNegative)
            {
                flag = true;
            } else
                flag = false;

            Console.WriteLine("The equality result between positive and negative numbers is: {0}", flag);

            return flag;
        }


        
        //Create sorting by the method of the Bubble 
        public static List<int> BubbleSort(List<int> myList)
        {
            int listLength = myList.Count;
            listLength -= 1;
            for (int i = 0; i < listLength; i++)
            {
                bool flag = true;
                for (int j = 0; j < listLength - i; j++)
                {
                    if (myList[j] > myList[j + 1])
                    {
                        int variable = myList[j];
                        myList[j] = myList[j + 1];
                        myList[j + 1] = variable;
                        flag = false;
                    }
                }

                if (flag) break;
            }
            return myList;
        }



        //Create method to insert numbers inside the list in position by users choosing
        public static List<int> InsertInList(List<int> myList, int placeToInsert, int numberToInsert)
        {

            myList.Insert(placeToInsert, numberToInsert);

            return myList;
        }
        
        //Create method for adding numbers at the end of the list
        public static List<int> InsertAtEnd(List<int> myList, int numberToInsert)
        {
            int endOfList = myList.Count;
            myList.Insert(endOfList, numberToInsert);

            return myList;
        }

        //Create method for adding numbers at the begining of the list
        public static List<int> InsertAtBeginning(List<int> myList, int numberToInsert)
        {
            int beginingOfList = 0;
            myList.Insert(beginingOfList, numberToInsert);

            return myList;
        }

        //Fill List with 10 numbers
        public static List<int> Input(List<int> myList)
        {
            myList.Add(-21);
            myList.Add(12);
            myList.Add(-53);
            myList.Add(44);
            myList.Add(-35);
            myList.Add(-66);
            myList.Add(-77);
            myList.Add(-88);
            myList.Add(-99);
            myList.Add(100);
            myList.Add(200);
            return myList;
        }

        //Create method for printing the List
        static List<int> PrintList(List<int> myList)
        {
            int listLength = myList.Count;
            for (int i = 0; i < listLength; i++)
            {
                Console.Write(myList[i] + ", ");
            }

            return myList;
        }

        //Create sorting by the method of the Bubble 
        
        static void Main(string[] args)
        {
            //Inititalize the list to work with
            List<int> intList = new List<int>();

            //Initialize counters
            int positiveCounter;
            int negativeCounter;

            //Implement the already created methods
            Input(intList);
            InsertInList(intList, 3, 69);
            InsertAtEnd(intList, 69);
            InsertAtBeginning(intList, 69);
            PrintList(intList);
            BubbleSort(intList);
            Console.WriteLine();
            Console.WriteLine();
            PrintList(intList);

            Console.WriteLine();
            Console.WriteLine();
            CountDigits(ref intList, out positiveCounter, out  negativeCounter);
            Console.WriteLine("In this List we have {0} positive and {1} negative numbers", positiveCounter, negativeCounter);

            CrusaderBase KuoriTheWhicDoctor = new CrusaderBase("Kuori The Which Doctor", 47);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(KuoriTheWhicDoctor.name);
            Console.WriteLine(KuoriTheWhicDoctor.level);
            KuoriTheWhicDoctor.Talk("My name is Kuori");

            //Nate NateDragon = new Nate("Nate", 0, 80);
            //NateDragon.Talk();
            //string NateName = "NateDragon";
            CrusadersFactory.CreateNate("Koko", 100, 200, 300); //This works in order to create Nate, but It gives error if i try Console.WriteLin(CrusadersFactory.NateDragon.name)
            CrusadersFactory.CreateNatali("Natali", 90, 150, 200);
            Console.WriteLine("Natali's name is {0}", CrusadersFactory.crusaderNatali.name);
            Console.WriteLine("Nate's health is {0}", CrusadersFactory.crusaderNate.name);
            Console.WriteLine("Nate's level is {0}", CrusadersFactory.crusaderNate.level);

            Natali NataliDragon = new Natali("Natali", 0, 100, 14);
            NataliDragon.Talk();
            Nate NateDragon = new Nate("Nate", 30, 200, 23);
            

            Console.WriteLine("Natali's health is: {0}", NataliDragon.health);
            CombatMgr.Fight( NataliDragon,  NateDragon);

        }
    }
}