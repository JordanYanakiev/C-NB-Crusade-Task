using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInputPrint
{
    class Program
    {

        //Method to count the positive and the negative numbres
        static void CountDigits(ref List<int> myList,  int counterPositive, int counterNegative)
        {
            int listLength = myList.Count;
            bool flag = false;

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

            Console.WriteLine("In this List we have {0} positive and {1} negative numbers", counterPositive, counterNegative);
            Console.WriteLine("The equality result between positive and negative numbers is: {0}", flag);
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
            int positiveCounter = 0;
            int negativeCounter = 0;

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
            CountDigits(ref intList, positiveCounter,  negativeCounter);
        }
    }
}