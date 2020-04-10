using System;
using System.Collections.Generic;
using System.Text;

namespace session2_projects
{
    class NonStaticClass
    {
        static NonStaticClass()
        {
            Console.WriteLine("Static Constructor is being called");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("nothing");

        }
    }
}
