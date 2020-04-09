using System;
using System.Collections.Generic;
using System.Text;

namespace session1_projects
{
    public class MyClass
    {
        public string myField = string.Empty;

        public MyClass()
        {

        }

        public void MyMethod(int parameter1, string parameter2)
        {
            string message = "this is the first class";

            int i, j, k, l = 0;

            int amount, num;

            int m, n,
                p,
                q = 0;

            int a = 100;
            int b = a;

            string message1 = "test";
            //int i = message1; CTRL + K and CTRL +C

            Console.WriteLine("first parameter {0}, second parameter {1}", parameter1, parameter2);
        }
        
        public int MyOtherProperty { get; set;}

        private int myProperty;

        public int MyProperty
        {
            get { return myProperty; }
            set { myProperty = value; }
        }
    }
}
