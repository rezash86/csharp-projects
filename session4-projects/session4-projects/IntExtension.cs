using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtensionMethods
{
    public static class MyIntExtension
    {
        //this 
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        public static bool IsSmallerThan(this int i, int value)
        {
            return i < value;
        }

        public static bool IsStringIsFoo(this string fooParameter, string val)
        {
            return fooParameter.Equals(val);
        }

    }
}
