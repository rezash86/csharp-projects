using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>()
            {
                "C#",
                "Java",
                "Python",
                "SQL"
            };

            //LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("Java")
                         select s;

            //LINQ Method syntax
            var result2 = stringList.Where(s => s.Contains("Java"));

            if (result == result2)
            {
                Console.WriteLine("Bingo!");
            }

            Console.WriteLine(result.ToList()[0]);
            Console.WriteLine(result2.ToList()[0]);


            IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentID = 1 , StudentName = "ttt1", Age = 13 },
                new Student(){ StudentID = 2 , StudentName = "ttt2", Age = 21},
                new Student(){ StudentID = 3 , StudentName = "ttt3", Age = 18 },
                new Student(){ StudentID = 4 , StudentName = "ttt4", Age = 20 },
                new Student(){ StudentID = 5 , StudentName = "ttt5", Age = 40 }
            };

            //LINQ Query to find out teenager student(between 12 and 20)
            var teenAgeStudents = from x in studentList
                                  where x.Age > 12 && x.Age < 20
                                  select x;

            //Console.WriteLine(teenAgeStudents.First());
            foreach (var _st in teenAgeStudents.ToList())
            {
                Console.WriteLine(_st);
            }

            IsTeenAger isTeen = s => s.Age > 12 && s.Age < 20;
            Student s1 = new Student() { Age = 25 };
            Console.WriteLine(isTeen(s1));


            IsYoungerThan isYoungerThan = (s, targettttttAge) => s.Age < targettttttAge;
            Student s2 = new Student() { Age = 25 };
            Console.WriteLine(isYoungerThan(s2, 26));


            Print pr = () => Console.WriteLine("lambda expressions are great");
            pr();

            IsAdult isAdult = (R) =>
            {
                int adultAge = 18;
                Console.WriteLine("adding local variable");
                return R.Age >= adultAge;
            };

            Student st = new Student() { Age = 25 };
            Console.WriteLine(isAdult(st));


            Console.WriteLine("--------------Filter ---------");
            IList<Student> studentList2 = new List<Student>()
            {
                new Student(){ StudentID = 0 , StudentName = "ttt0", Age = 13 },
                new Student(){ StudentID = 1 , StudentName = "ttt1", Age = 21},
                new Student(){ StudentID = 2 , StudentName = "ttt2", Age = 18 },
                new Student(){ StudentID = 3 , StudentName = "ttt3", Age = 20 },
                new Student(){ StudentID = 4 , StudentName = "ttt4", Age = 40 }
            };

            var filteredResult = studentList2.Where((s, i) =>
            {
                if (i % 2 == 0) //even
                {
                    return true;
                }

                return false;
            });

            foreach (var std in filteredResult)
            {
                Console.WriteLine(std.StudentName);
            }

            //using predicate
            var filteredResult2 = studentList2.Where(st2 => st2.Age > 12).Where(st1 => st1.Age < 20);

            //Query Syntax
            var filteredResult3 = from student in studentList2
                                  where student.Age > 12 && student.Age < 20
                                  select student;

            Console.WriteLine("-------------------using ofType----------");
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { Age = 12 });

            //Query opertaor to filter based on type
            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var stringResult2 = mixedList.OfType<string>();

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            //check Sorting Query syntax
            var orderByResult1 = from stud in studentList2
                                 orderby stud.StudentName
                                 select stud;

            var orderbyResult2 = studentList2.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);


            Console.WriteLine("-------------------using groupby----------");

            IList<Student> studentList3 = new List<Student>()
            {
                new Student(){ StudentID = 0 , StudentName = "ttt0", Age = 13 },
                new Student(){ StudentID = 1 , StudentName = "ttt1", Age = 21},
                new Student(){ StudentID = 2 , StudentName = "ttt2", Age = 18 },
                new Student(){ StudentID = 3 , StudentName = "ttt3", Age = 13 },
                new Student(){ StudentID = 4 , StudentName = "ttt4", Age = 40 },
                new Student(){ StudentID = 2 , StudentName = "ttt5", Age = 18 },
            };

            //Group by Query syntax
            var groupedResult = from s in studentList3
                                    //where
                                    //orderby 
                                group s by s.Age;

            //Group by method syntax
            var groupedResult2 = studentList3.GroupBy(s => s.Age);

            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age group:{0}", ageGroup.Key);//each group has a key

                foreach (Student s in ageGroup)
                    Console.WriteLine("Student Name:{0}", s.StudentName);//each group has an inner collection
            }

            Console.WriteLine("-------------------using lookup----------");
            var groupedResult3 = studentList3.ToLookup(s => s.Age);

            foreach (var ageGroup in groupedResult3)
            {
                Console.WriteLine("Age group:{0}", ageGroup.Key);//each group has a key

                foreach (Student s in ageGroup)
                    Console.WriteLine("Student Name:{0}", s.StudentName);//each group has an inner collection
            }

            Console.WriteLine("-------------------Join Operator----------");
            IList<string> strList1 = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four"
            };

            IList<string> strList2 = new List<string>()
            {
                "One",
                "Two",
                "Five",
                "Six"
            };

            var innerJoin = strList1.Join(      //outer sequence
                                        strList2, //inner sequence
                                        st1 => st1, //outerkeySelector
                                        st2 => st2, //innerKeyselector
                                        (st1, st2) => st1); //resultSelector

            foreach (var str in innerJoin)
            {
                Console.WriteLine(str);
            }

            //Join One to Many
            IList<Student> studentList4 = new List<Student>()
            {
                new Student(){ StudentID = 0 , StudentName = "ttt0", Age = 13, StandardID =1 },
                new Student(){ StudentID = 1 , StudentName = "ttt1", Age = 21, StandardID =1},
                new Student(){ StudentID = 2 , StudentName = "ttt2", Age = 18, StandardID =2 },
                new Student(){ StudentID = 3 , StudentName = "ttt3", Age = 13, StandardID =2 },
                new Student(){ StudentID = 4 , StudentName = "ttt4", Age = 40 },
                new Student(){ StudentID = 2 , StudentName = "ttt5", Age = 18 },
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard(){StandardID =1 , StandardName ="standard 1"},
                new Standard(){StandardID =2 , StandardName ="standard 2"},
                new Standard(){StandardID =3 , StandardName ="standard 3"}
            };

            //Method syntax
            var innerJoin2 = studentList4.Join( //outer sequence
                            standardList, //inner sequence
                            student => student.StandardID, //outer key sequence
                            standard => standard.StandardID, // inner key sequence
                            (student, standard) => new // result selector
                            {
                                StdName = student.StudentName,
                                StandName = standard.StandardName
                            }
                );


            //Query syntax
            var innerJoin3 = from s in studentList4
                             join sl in standardList
                             on s.StandardID equals sl.StandardID
                             select new
                             {
                                 StdName = s.StudentName,
                                 StandName = sl.StandardName
                             };


            foreach (var obj in innerJoin2)
            {
                Console.WriteLine("{0} - {1}", obj.StdName, obj.StandName);
            }


            //Select
            var selectResult1 = from s in standardList
                                select s.StandardName;

            var selectResult2 = from s in standardList
                                select new
                                {
                                    StandName = s.StandardName
                                };
            selectResult2.ToList(); //as an Item source to the data grid

            //All operator True if All the elements satisfy the condition
            bool areAllStudentsTeenAge = studentList4.All(s => s.Age > 12 && s.Age < 20);

            //Any operator True if any element satisfy the condition
            bool isAnyStudentsTeenAge = studentList4.Any(s => s.Age > 12 && s.Age < 20);


            //Contains
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result1 = intList.Contains(10);
            //With comparator !

            //SUM
            var total = intList.Sum();


            var sumOfAge1 = studentList4.Sum(s => s.Age);

            var sumOfAge2 = studentList4.Sum(s => {
                if (s.Age > 18)
                    return 1;
                else
                    return 0;
            });

            studentList4.ElementAtOrDefault(2);

            //Concat
            IList<int> intList1 = new List<int>() { 1, 2, 3, 4, 5 };
            IList<int> intList2 = new List<int>() { 6, 7, 8, 9, 10 };

            IList<string> intList3 = new List<string>() { 6, 7, 8, 9, 10 };

            var collection = intList1.Concat(intList2);

            intList1.Distinct();

            intList1.Intersect(intList2);

            intList1.Union(intList2);
        }

        delegate bool IsAdult(Student stud);
        
        delegate void Print();

        delegate bool IsTeenAger(Student stud);

        delegate bool IsYoungerThan(Student student, int targetAge);

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

            public int StandardID { get; set; }

            public override string ToString()
            {
                return $"StudentID = {StudentID} StudentName = {StudentName} Age = {Age}";
            }
        }
        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }

    }
}
