using System;
using System.Collections.Generic;
using System.Text;

namespace session2_projects
{
    public class ClassStaticCtor
    {
        public static int counter = 0;

        public ClassStaticCtor()
        {
            counter++;
        }

        static ClassStaticCtor()
        {
            counter++;
        }
    }
}
