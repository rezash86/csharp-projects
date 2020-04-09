using System;
using System.Collections.Generic;
using System.Text;

namespace session1_projects
{
    struct Employee 
    {
        public int EmpId;
        public string FirstName;
        public string LastName;
        
        static Employee()
        {
            Console.WriteLine("Object has been created");
        }

        //compile error
        //public Employee()
        //{

        //}

        public Employee(int empId, string fname, string lname)
        {
            EmpId = empId;
            FirstName = fname;
            LastName = lname;
        }

        public void TOTO()
        {
            //do nothing
        }
    }
   

    //struct Manager: Employee
    //{

    //}
}
