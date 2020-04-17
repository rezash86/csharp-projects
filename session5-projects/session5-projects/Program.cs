using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace session5_projects
{
    
    //Task1-Asg1
    struct BankAccount
    {
        AccountType accountType;
        float deposit;
        
    }

    enum AccountType
    {
        checking = 0,
        saving = 1,
        lineOfCredit = 2
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Task 3-Asg1
            var shape = new
            {
                color = "blue",
                size = "large",
                model = "new"
            };


            //Task 4-Asg1
            int x = 10;
            Console.WriteLine("x before calling the method  = {0}", x);
            DoCalcByValue(x);
            Console.WriteLine("x after calling the method  =  {0}", x);

            Console.WriteLine("------------------------------------");

            Console.WriteLine("x before calling the method by reference  = {0}", x);
            DoCalcByReference(ref x);
            Console.WriteLine("x after calling the method  by reference =  {0}", x);

            //Task5-Asg1-> Interpolation
            Console.WriteLine("Enter 3 numbers = ");
            int x1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int x3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"the value of first = {x1} " +
                $"and the value of seconed = {x2} " +
                $"and the thrid one is {x3} ");


            //Task6-Asg1 ->hours Left
            DateTime nextYear = new DateTime(2021, 01, 01);
            DateTime todayDate = DateTime.Now;
            TimeSpan timeLeft = nextYear.Subtract(todayDate);

            Console.WriteLine($"time left until next year is {timeLeft.TotalHours}");

            //Task7-Asg1
            string myInformation = @"name = Reza
                family = sh
                email = shalchian.r@gmail.com";

            Console.WriteLine(myInformation);

            //Task8-Asg1
            Console.WriteLine("name:reza" + "email: shalchian.r@gmail.com");


            //Task9-Asg1
            var myname1 = "reza";
            dynamic myname2 = "reza";

            //var myname3;
            //myname3 = "reza";

            dynamic myname4;
            myname4 = "reza";

            myname2 = 33;
            //myname1 = 11;

            //Task10-Asg1
            PrintShape(shape);


            //Task1-Asg2
            StringBuilder sb = new StringBuilder();
            sb.Append("toto");
            sb.Append("PoPo");
            sb.Append("JOJO");

            Console.WriteLine(sb);


            //Task3-Asg2
            Utils.CalculateArea(5);

            //Task3-Asg2
            //2D
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[2] { 1, 2 };


            Console.WriteLine("2D ");
            foreach (int[] arr in jaggedArray)
            {
                foreach (int number in arr)
                {
                    Console.Write(number+ " ");

                }
            }

            //3D
            int[][][] jArr3D = new int[2][][]
            {
                new int[1][]
                {
                    new int[3]{ 1,2,3}
                },
                new int[2][]
                {
                     new int[1]{ 1},
                     new int[3]{ 1,2,3}
                }
            };

            Console.WriteLine("3D ");

            foreach (int[][] arr2D in jArr3D)
            {
                foreach(int[] arr1D in arr2D)
                {
                    foreach (int number in arr1D)
                    {
                        Console.Write(number+ " ");
                    }
                }
            }

            Console.WriteLine("-------------------");

            var jaggedArray2 = new object[3];
            jaggedArray2[0] = new[] { 1, 2, 3 };
            jaggedArray2[1] = new[] { "str", "onemore" };
            
            var property1 = new { PROP = 14 };
            var property2 = new { PROP = 12 };
            jaggedArray2[2] = new[] {
                property1,
                property2, 
                new { PROP = 1 } 
            };

            var shape1 = new
            {
                color = "blue",
                size = "large",
                model = "new"
            };

            //Task5-Asg2=> indexer

            IndexerRepository repo = new IndexerRepository();
            repo[0] = 1;
            repo[1] = 2;
            repo[2] = 3;

            for(int j=0; j<repo.getSize(); j++)
            {
                Console.WriteLine(repo[j]);
            }

            //Task6-Asgn2
            var info = Tuple.Create<string, string, int>("reza", "honda", 1);
            Console.WriteLine("name: {0}",info.Item1);
            Console.WriteLine($"Car: {info.Item2}");

            //Task1-Asgn3
            ArrayList studentList = new ArrayList();

            studentList.Add(new Student(1, "toto"));
            studentList.Add(new Student(2, "Popo"));

            foreach(var st in studentList)
            {
                Console.WriteLine(st.ToString());
            }

            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student(1, "koko"));
            listStudent.Add(new Student(2, "jojo"));

            listStudent.ForEach(s => Console.WriteLine(s.name));
            //it uses toString()
            listStudent.ForEach(Console.WriteLine);


            //Task2-Asgn3
            MyGenericClass<string>.PrintValue("test");
            MyGenericClass<int>.PrintValue(98998898);

            //Task3-Asgn3
            Hashtable myHashtable = new Hashtable();
            myHashtable.Add(1, "blue");
            myHashtable.Add(2, "red");
            myHashtable.Add(3, "green");
            myHashtable.Add(4, "yellow");

            foreach(var key in myHashtable.Keys)
            {
                Console.WriteLine($"{key} and the value : {myHashtable[key]}");
            }

            //Task4-Asgn3
            MyconstraintGenericClass<Student>.PrintValue(new Student(5, "t"));
            MyconstraintGenericClass<string>.PrintValue("t");
            //string and String are the same !

            //Task6-Asgn3
            Calculate calc_area = CalculateArea;
            calc_area(20);

            Calculate calc_biggest = CalculateBiggest;
            calc_biggest(4);

            //Task1-Asgn4
            string str = "Programming is the best career";
            
            Splitter s1 = (
                    (sentence) =>
                    {
                        String[] arr = sentence.Split(" ");
                        foreach(string s in arr)
                        {
                            Console.WriteLine(s);
                        }
                    }
                );

            s1(str);

            //Task2-Asgn4
            Product pr = (x, y) => x * y;
            Console.WriteLine(pr(3, 5));

            //Task3-Asgn4

            Predicate<Employee> higherSalary1 = delegate (Employee e) {
                return (e.salary > 200000);
            };
            Predicate<Employee> higherSalary2 = (Employee e) => {
                return (e.salary > 200000);
            };



            Employee empx = new Employee("sakibol", 500000);
            if (higherSalary1(empx))
            {
                Console.WriteLine(empx.name + " is a manager");
            }

            Predicate<double> higherSalary3 = salary => salary > 200000;

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("toto1", 100000));
            employees.Add(new Employee("toto2", 200000));
            employees.Add(new Employee("toto3", 300000));

            employees.ForEach(empx => {
                if (higherSalary1(empx))
                {
                    Console.WriteLine(empx.name + " is a manager");
                }
            });

            employees.ForEach(empx => {
                if (higherSalary3(empx.salary))
                {
                    Console.WriteLine(empx.name + " is a manager");
                }
            });



            //Task4-Asgn4
            if (Directory.Exists("directoryName"))
            {
                Directory.Delete("directoryName");
            }


            //Task5-Asgn4
            int? myNullableField1 = 10;
            int variable1 = myNullableField1 ?? 20;

            int? myNullableField2 = null;
            int variable2 = myNullableField2 ?? 20;

            //Task6-Asgn4
            Nullable<int> myNullableInt1 = 10;
            Nullable<int> myNullableInt2 = null;

        }

        public delegate void Splitter(string str);
        public delegate int Product(int a, int b);


        public delegate double Calculate(int radius);
        public static double CalculateArea(int radius)
        {
            return radius * 10000;
        }

        public static double CalculateBiggest(int radius)
        {
            return radius * 2;
        }

        public static void  DoCalcByValue(int x)
        {
            x = x * 2;
        }

        public static void DoCalcByReference(ref int x)
        {
            x = x * 2;
        }

        public static void PrintShape(dynamic myShape)
        {
            Console.WriteLine($"Color : {myShape.color}, size:{myShape.size}, model:{myShape.model}");
        }


        class Employee
        {
            public string name;
            public double salary;

            public Employee(string name, double salary)
            {
                this.name = name;
                this.salary = salary;
            }
        }
    }
}
