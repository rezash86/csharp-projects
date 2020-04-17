using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class MyGenericClass<T>
    {
        public static void PrintValue(T value)
        {
            Console.WriteLine(value);
        }

    }
}
