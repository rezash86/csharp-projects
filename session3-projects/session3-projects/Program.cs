using System;
using System.Collections;
using System.Collections.Generic;

namespace session3_projects
{
    class Program
    {

        public delegate void Print(int value);

        static void Main2(string[] args)
        {
            //ArrayList Examples
            //ArrayList is Non-Generic
            ArrayList myArr = new ArrayList(); // Recommended

            IList myArryList1 = new ArrayList(); //some limitations
            ICollection myArryList2 = new ArrayList();
            IEnumerable myArryList3 = new ArrayList();

            myArr.Add(1);
            myArr.Add("two");
            myArr.Add(2.5);

            //insert
            myArr.Insert(3, "test index 3");

            //insertRange
            IList arrTemp1 = new ArrayList();
            arrTemp1.Add(100);
            arrTemp1.Add(200);

            ArrayList arrList2 = new ArrayList();
            arrList2.Add(10);
            arrList2.Add(20);
            arrList2.Add(30);

            arrList2.InsertRange(2, arrTemp1);

            //foreach (var item in myArr)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            foreach (var item in arrList2)
            {
                //Console.WriteLine(item.ToString());
            }

            //Remove the object
            myArr.Remove("two");


            //SortedList
            SortedList sortedList1 = new SortedList();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");


            for (int i = 0; i < sortedList1.Count; i++)
            {
                //Console.WriteLine("key:{0} , value:{1}", sortedList1.GetKey(i),
                //    sortedList1.GetByIndex(i));
            }
            //Remove an element
            sortedList1.Remove(3);

            //Console.WriteLine("after remove");

            //key-value pair can be casted to DictionaryEntry
            foreach (DictionaryEntry element in sortedList1)
            {
                //Console.WriteLine("key:{0} , value:{1}", element.Key, element.Value);
            }

            //check the existance of a key
            sortedList1.ContainsValue("Five");
            //key must be unique and cannot be null

            //HashTable examples
            Hashtable ht1 = new Hashtable();
            ht1.Add(1, "Three");
            ht1.Add("two", 2);
            ht1.Add(3, "Three");
            ht1.Add(4, "Four");

            Hashtable ht2 = new Hashtable()
            {
                {1, "one" },
                {2, "two" },
                {3, "three"}
            };

            //Access to the items
            string strValue1 = (string)ht1[1];

            //Iterate through the items
            foreach (DictionaryEntry item in ht1)
            {
                //Console.WriteLine("key:{0} , value:{1}", item.Key, item.Value);
            }

            //Stack
            Stack myStack1 = new Stack();
            myStack1.Push("test");
            myStack1.Push(1);
            myStack1.Push(null);

            foreach (var item in myStack1)
            {
                //Console.WriteLine(item);
            }

            //pop removes and return
            //peek will keep the item in the stack
            Stack myStack2 = new Stack();
            myStack2.Push(1);
            myStack2.Push(2);
            myStack2.Push(3);
            myStack2.Push(4);

            //while(myStack2.Count> 0)
            //{
            //    Console.WriteLine(myStack2.Pop());
            //}

            //contain
            //clear


            //Queue
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //peek will not remove the elements

            MyGenericClass<int> intGenericObj = new MyGenericClass<int>(15);

            intGenericObj.genericMethod(200);


            //Generic Collection
            Queue<int> genericQueue = new Queue<int>();
            genericQueue.Enqueue(7);


            MyGenericClass2<String> myGenericClass2 = new MyGenericClass2<String>("test");

            MyGenericClass3<string, TestStructure> myGenericClass3 = new MyGenericClass3<string, TestStructure>();


            //List Generic type
            //Genric Collections => List, HashSet, Dictionary, Queue<> , Stack<>
            List<int> intList = new List<int>();
            intList.Add(1);


            //Generic List
            IList<int> tempList1 = new List<int>();
            List<int> tempList2 = new List<int>();


            //Non-generic
            IList tempArr = new ArrayList();

            //Delegate Example


            Print printDel = PrintNumber;
            printDel.Invoke(10000);
            printDel(200);

            //PrintNumber(10000);
            //PrintMoney(200);

            Print printDelMoney = PrintMoney;
            printDelMoney(100);



        }


        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number : {0}", num);
        }

        
        public static void PrintMoney(int money)
        {
            Console.WriteLine("money : {0:C}", money);
        }

        struct TestStructure
        {

        }
    }
}
