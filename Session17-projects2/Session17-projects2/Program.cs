using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session17_projects2
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddUpdateDeleteEntityConnectedScenario();
            AddUpdateDeleteEntityDisConnectedScenario();
            LinqToEntitiesQuery();
            FindEntity();
            LazyLoading();
            ExcuteRawSQLQueries();
            ExcuteSQLCommands();

        }

        public static void AddUpdateDeleteEntityConnectedScenario()
        {
            Console.WriteLine("Adding a new student connected mode scenario started ");
            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;
                var newStudent = context.Students.Add(
                    new Student()
                    {
                        StudentName = "Reza",
                        StudentAddress = new StudentAddress()
                        {
                            Address1 = "address1",
                            City = "Montreal"
                        },
                        Height = Decimal.Parse("2.5")
                    }); ;

                context.SaveChanges ();

                newStudent.StudentName = "Donald";
                context.SaveChanges();

                context.Students.Remove(newStudent);
                context.SaveChanges();
            }

           Console.WriteLine("Adding a new student connected mode scenario finished");
        }

        public static void AddUpdateDeleteEntityDisConnectedScenario()
        {
            Console.WriteLine("Adding a new student dicconnected mode  scenario started");

            var newStudent = new Student() { StudentName = "Jack" };
            var existingStudent = new Student() { StudentID = 4, StudentName = "Al capone" };

            using (var context = new mySchooldbEntities()){
                //Log db commands to console
                context.Database.Log = Console.WriteLine;

                context.Entry(newStudent).State = newStudent.StudentID == 0 ?
                    System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                context.Entry(existingStudent).State = existingStudent.StudentID == 0 ?
                    System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }


            Console.WriteLine("Adding a new student dicconnected mode  scenario finished");

        }

        public static void LinqToEntitiesQuery()
        {
            Console.WriteLine("LinqtoEntities Query starts");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                //Retrive by Query syntax
                var students = (from s in context.Students
                                where s.StudentName == "Donald"
                                select s).ToList<Student>();

                foreach (var student in students)
                {
                    Console.WriteLine(student.StudentID);
                }

                Console.WriteLine("students with the same name");
                //Retrive by method syntax
                var studentsWithSameName = context.Students
                    .GroupBy(s => s.StudentName)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key);

                foreach(var student in studentsWithSameName)
                {
                    Console.WriteLine(student);
                }

            }

            Console.WriteLine("LinqtoEntities Query finished");
        }
        public static void FindEntity()
        {
            Console.WriteLine("Find entity started");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                var stud = context.Students.Find(5);
                Console.WriteLine($"{stud.StudentName}");
            }

            Console.WriteLine("Find entity finished");
        }

        public static void LazyLoading()
        {
            Console.WriteLine("LazyLoading started");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                Student student = context.Students.Where(s => s.StudentID == 1).FirstOrDefault<Student>();

                //Standard std = student.Standard
                //do another query to fetch the dependant tables
                ICollection<Cours> cours = student.Courses;
            }

            Console.WriteLine("LazyLoading finished");

        }

        public static void ExcuteRawSQLQueries()
        {
            Console.WriteLine("ExcuteRawSQLQueries started");

            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                var studentList1 = context.Students.SqlQuery("select * from Students").ToList();
                //var studentList2 = context.Students.SqlQuery
                //    ("select StudentId, StudentName, DateOfBirth, Height from Students").ToList();
            }

            Console.WriteLine("ExcuteRawSQLQueries finished");

        }

        public static void ExcuteSQLCommands()
        {
            Console.WriteLine("ExcuteSQLCommands started");
            
            using (var context = new mySchooldbEntities())
            {
                context.Database.Log = Console.WriteLine;

                //Insert command
                int numberOfRowsInserted = context.Database.ExecuteSqlCommand("insert into Students" +
                    "(studentname, height, weight)" +
                    "values('Johnny', 110, 87) ");

            }

            Console.WriteLine("ExcuteSQLCommands finished");

        }
    }
}
