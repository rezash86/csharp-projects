using System;
using System.Collections.Generic;
using System.Text;

namespace session3_projects
{
    class EventExample
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumbers(EventMessage); //4 - subscribe event
            //a.Add();



            //second example
            Metronome m = new Metronome();
            Listener l = new Listener();
            l.Subscribe(m);
            m.Start();


        }
        // 5- define the method => delegate will excute the function
        static void EventMessage()
        {
            Console.WriteLine("Event triggered");
        }

        class AddTwoNumbers
        {
            public delegate void dg_OddNumbers(); // 1 - declared delegate
            public event dg_OddNumbers ev_OddNumber; // 2 - declare event

            public void Add()
            {
                int result;
                result = 5 + 4;
                Console.WriteLine(result.ToString());

                //firing the event
                if (result % 2 != 0 && ev_OddNumber != null)
                {
                    ev_OddNumber(); //3 - raise event (excution)
                }
            }

        }
    }
}