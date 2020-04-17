using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class MyconstraintGenericClass<T> where T: class
    {
        public static void PrintValue(T value)
        {
            Console.WriteLine(value);
        }
    }
}
