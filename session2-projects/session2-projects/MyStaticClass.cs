using System;
using System.Collections.Generic;
using System.Text;

namespace session2_projects
{
    public class MyStaticClass
    {
        public static int myStaticVariable = 0;

        static MyStaticClass()
        {
            Console.WriteLine("Static Constructor is being called");
        }

        public static void MystaticMethod()
        {

        }

         public static int MyProperty { get; set; }


        //private int x;
        //public int X
        //{
        //    get
        //    {
        //        return x;
        //    }
        //    set
        //    {
        //        x = value;
        //    }
        //}
        public int X { get; set; }
    }
}
