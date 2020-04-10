using System;
using System.Collections.Generic;
using System.Text;

namespace session2_projects
{
    class StringDataStore
    {
        private string[] strArr = new string[10]; //internal data storage

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                return strArr[index];
            }
            set
            {
                if (index < 0 && index >= strArr.Length)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                strArr[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach(string str in strArr)
                {
                    if(str != null && str.ToLower() == name.ToLower())
                    {
                        return str;
                    }
                }
                return null;
            }         
        }
    }
}