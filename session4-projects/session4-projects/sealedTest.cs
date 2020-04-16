using System;
using System.Collections.Generic;
using System.Text;

namespace session4_projects
{
    //this class can not be inherited
    sealed class sealedTest
    {
        private int type;

        //public int Type { get; set; }
        
        public int getType()
        {
            return type;
        }
        //public void setType(int type)
        //{
        //    this.type = type;
        //}

    }
}
