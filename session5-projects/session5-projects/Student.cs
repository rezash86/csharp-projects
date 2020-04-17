using System;
using System.Collections.Generic;
using System.Text;

namespace session5_projects
{
    class Student
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        
        public override string ToString()
        {
            return $"name = {this.name}";
        }
    }
}
