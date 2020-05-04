using System;

namespace EF6CodeFirstDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }

            //I have to open a connection
            //I have to build a data adapter
            //I have to write query insert into student ....


            //with entity framework need to instantiate
            //the dbcontext (schoolcontext)
            //and then have access to the container (EF API)

            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}