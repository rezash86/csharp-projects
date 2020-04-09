using System;
using System.Collections.Generic;
using System.Text;

namespace session1_projects
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        
        public void DisplayStudentDetail()
        {
            Console.WriteLine("Name {0}", this.StudentName);
            Console.WriteLine("Age {0}", this.Age);
            Console.WriteLine("Id {0}", this.StudentID);

        }
    }
}
