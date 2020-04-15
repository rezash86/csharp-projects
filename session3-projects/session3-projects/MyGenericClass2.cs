using System;
using System.Collections.Generic;
using System.Text;

namespace session3_projects
{
    //define a generic class
    class MyGenericClass<R>
    {
        //add a generic member
        private R genericMember;

        //generic constructor
        public MyGenericClass(R value)
        {
            genericMember = value;
        }
        //generic method
        public R genericMethod(R genericParameter)
        {
            return genericMember ;
        }

        public R MyProperty { get; set; }
    }
}
