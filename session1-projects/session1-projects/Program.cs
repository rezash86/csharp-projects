using System;

namespace session1_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            //Console.WriteLine("Type of i {0}", i.GetType().ToString());

            var str = "Johnabbott";
            //Console.WriteLine("Type of i {0}", str.GetType().ToString());

            byte b1=   255;
            //byte b2 = -128; //=> byte 0 to 255 compile erro

            //Console.WriteLine("the max of Byte {0}", Byte.MaxValue);

            short s1 = -32700;
            //short s2 = 35000; //compile error
            //Console.WriteLine("the max of short {0}", short.MaxValue);

            string s1Test = "s";

            string str1 = "Hello";
            String str2 = "Hello";

            char[] chars = { 'J', 'O', 'H', 'N' };
            string strConverted1 = new string(chars);

            foreach (char c in strConverted1)
            {
                //Console.WriteLine(c);
            }

            // escape character
            string compiled_error = "this string \"has\" an error"; //adding \

            //character sequence
            string str_sequence1 = @"xyz\raaa"; //adding @
            string str_sequence2 = @"x\\yz\ra@aa"; //adding @

            //multiline
            string multi_line = @"this is a str \
                                second line \
                                multi line";
            
            //concatination
            string name = "reza" + "shalchian";

            string firstname = "reza";
            string lastname = "shal";


            string full_name = firstname + ", " + lastname;


            //Interpolation
            string fName = "Bradd";
            string lName = "pitt";

            string fullName = $"Mr {fName} {lName}";


            //DataTime
            DateTime dt1 = new DateTime(); //01/01/0001

            DateTime dt2 = new DateTime(2020, 12, 31);

            
            
            //using timespan
            DateTime dt3 = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt3.Add(ts);

            DateTime dt4 = new DateTime(2014, 11, 01);
            TimeSpan diffTime = dt3.Subtract(dt4);

            DateTime added = dt3 + ts;
            DateTime subtract = dt3 - ts;
            Boolean compare = dt3 == dt4;

            //conversion to String
            var dt = DateTime.Now;

            //Console.WriteLine("current time " + dt.ToString("d"));
            //Console.WriteLine("current time in MM/dd/yyyy format " + dt.ToString("MM/dd/yyyy"));
            //Console.WriteLine("current time in dddd, dd MMMM yyyy format " + 
            //    dt.ToString("dddd, dd MMMM yyyy"));

            //Console.WriteLine("current time in HH:mm:ss format " +
            //        dt.ToString("HH:mm:ss"));

            //convert string to datetime
            var strDate = "5/121/2020";

            DateTime dtConverted;
            var isValidDate = DateTime.TryParse(strDate, out dtConverted);

            if (isValidDate)
            {
                //Console.WriteLine("date time converted " + dtConverted);
            }
            else
            {
                //Console.WriteLine($" {strDate} was not valid");
            }

            //Call by value example
            //int variable = 100;
            //Console.WriteLine($"variable before call is {variable}");
            //ChangeValue(variable);
            //Console.WriteLine($"variable after call is {variable}");

            //call by reference example
            //MyClass myClass = new MyClass();
            //myClass.myField = "Reza";

            //ChangeByReference(myClass);
            //Console.WriteLine($"variable after call is {myClass.myField}");

            var myAnonymousType = new
            {
                firstProperty = "my first one",
                secondProperty = "my second one",
                thirdProperty = "my third one"
            };

            var nestedAnonymousType = new
            {
                firstProperty = "my first one",
                secondProperty = "my second one",
                thirdProperty = "my third one",
                anotherAnonymouseType = new { 
                    nestedOne = "Nested one"
                }
            };

            var nestedValue = nestedAnonymousType.anotherAnonymouseType.nestedOne;

            //DoSomething(myAnonymousType);

            //compiler will translate -> object myDynamicVariable = 1


            //dynamic type
            //dynamic myDynamicVariable = 1;
            //Console.WriteLine(myDynamicVariable.GetType().ToString());


            dynamic dynamicStudnet = new Student();
            dynamicStudnet.StudentID = 23;
            dynamicStudnet.StudentName = "Peter";
            dynamicStudnet.Age = 30;


            //dynamicStudnet.DisplayStudentDetail();
            //this throws exception
            //dynamicStudnet.fakeMethod();

            //Employee emp1 = new Employee();
            //emp1.FirstName = "reza";

            //Employee emp2 = new Employee(); 
            //emp2.LastName = "shalchian";
            //emp2.TOTO();

            /*
            Employee emp3 = new Employee(1, "Steve", "jobs");
            Console.WriteLine(emp3.EmpId);
            Console.WriteLine(emp3.FirstName);
            Console.WriteLine(emp3.LastName);
            */

            //Console.WriteLine(WeekendDays.Saturday);
            //Console.WriteLine((int)WeekendDays.Sunday);


            //Console.WriteLine(Enum.GetName(typeof(WeekendDays), 1));

            //foreach(string weekendday in Enum.GetNames(typeof(WeekendDays)))
            //{
            //    Console.WriteLine(weekendday);
            //}

            WeekendDays convertedweekndDay;
            Enum.TryParse("1", out convertedweekndDay);
            Console.WriteLine(convertedweekndDay);
        }

        static void DoSomething(dynamic param)
        {
            var property = param.firstProperty;
            Console.WriteLine(property);
        }

        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine($"variable in the  call is {x}");
        }

        static void ChangeByReference(MyClass myclass)
        {
            myclass.myField = "Sakibul";
        }

    }
}
