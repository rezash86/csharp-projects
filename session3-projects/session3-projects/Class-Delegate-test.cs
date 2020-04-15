using System;
using System.Collections.Generic;
using System.Text;

namespace session3_projects
{
    class Class_Delegate_test
    {
        public delegate void Display(int n);

        public delegate int Operation(int a, int b);

        static void Main2(string[] args)
        {
            // there is no new !!!
            Display display = Prettyprint;
            Operation operation = Sum;

            Calculate(display, operation);

        }

        public static void Calculate(Display display, Operation operation)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            
            var result = operation(a, b);
            display(result);
            //display.Invoke(result);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Product(int a, int b)
        {
            return a * b;
        }

        public static void print(int a)
        {
            Console.WriteLine(a);
        }

        public static void Prettyprint(int a)
        {
            Console.WriteLine("-------pretty print---------");
            Console.WriteLine(a);
            Console.WriteLine("----------------");
        }
    }
}
