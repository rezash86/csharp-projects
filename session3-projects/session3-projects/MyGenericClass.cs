using System;
using System.Collections.Generic;
using System.Text;

namespace session3_projects
{
    //define a generic class
    class MyGenericClass2<R> where R:class
    {
        //add a generic member
        private R genericMember;

        //generic constructor
        public MyGenericClass2(R value)
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
