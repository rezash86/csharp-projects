using System;
using System.Text;

namespace session2_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stringbuilder
            /*
            StringBuilder sb = new StringBuilder("My text", 50);
            sb.Append(" is ");
            sb.Append(" here ");

            Console.WriteLine(sb);

            //sb.Remove(1, 2);

            Console.WriteLine("after removal  " + sb);

            StringBuilder sb2 = new StringBuilder("Your Money is ");
            sb2.AppendFormat("{0:C}", 25);

            Console.WriteLine(sb2);


            sb.Insert(4, "T");

            Console.WriteLine(sb);

            sb.Replace("e", "G");
            Console.WriteLine(sb);

            */
            //Stringbuilder is mutable => you can change the object
            //Stringbuilder is faster than string
            //when we want to append some strings(texts) its better to use stringbuilder


            //Partial Class
            PartialClass pc = new PartialClass();
            pc.DummyMethod1();

            //static class example
            //MyStaticClass.MystaticMethod();
            //MyStaticClass.myStaticVariable = 100;
            //MyStaticClass.MyProperty = 54;
            //Console.WriteLine(MyStaticClass.MyProperty);

            //In C# if a method/field/property is static you can only have access
            //throgh that attribite by using ClassName.method/field/property


            //Static constructors
            //MyStaticClass.myStaticVariable = 100;
            //MyStaticClass.MyProperty = 200;
            //MyStaticClass.myStaticVariable = 300;
            //MyStaticClass.MyProperty = 400;


            NonStaticClass obj1 = new NonStaticClass();
            NonStaticClass obj2 = new NonStaticClass();
            NonStaticClass obj3 = new NonStaticClass();


            ClassStaticCtor c1 = new ClassStaticCtor();
            ClassStaticCtor c2 = new ClassStaticCtor();
            //Console.WriteLine(ClassStaticCtor.counter);

            //Array
            int[] nums1;
            string[] names;
            double[] salaries;
            object[] objs;

            MyStaticClass[] stclass;

            int[] nums2 = new int[4];
            int[] nums3 = new int[4] { 12, 13, 14, 15 };
            int[] nums4 = new int[] { 12, 13, 14, 15, 16 };
            int[] nums5 = { 12, 13, 14, 15, 16 };
            int x = nums5[0]; //x = 12;

            int[] nums6 = new int[5];
            nums6[0] = 1;
            nums6[1] = 2;
            nums6[2] = 3;
            nums6[3] = 4;

            //simple loop
            for (int i = 0; i < nums6.Length; i++)
            {
                Console.Write(nums6[i]);
            }

            //foreach
            foreach (var item in nums6)
            {
                //Console.Write(item);
            }

            Console.WriteLine();
            string[] fnames = { "AAA", "BBB", "CCC" };
            foreach (var name in fnames)
            {
                //Console.Write(name + "  ");
            }

            //Implicitely Typed Array
            var nums = new[] { 10, 11, 12, 14 };
            Console.WriteLine(nums.GetType().IsArray);

            if (nums.GetType().IsArray) {
                foreach (var it in nums)
                {

                    if (Type.GetTypeCode(it.GetType()) == TypeCode.Int32)
                    {
                        Console.Write(it.ToString() + " ");
                    }

                }
            }

            //Multidimensial Array
            int[,] arr2D;
            int[,,] arr3D;


            int[,] arr2d1 = new int[3, 2]
            {
               {1,2 }, {3,4}, {5,6}
            };

            int[,] arr2d2 =
            {
               {1,2 }, {3,4}, {5,6}
            };

            //arr2d[0,0] => returns 1;
            //arr2d[2,1] => returns 6;


            //Jagged array
            int[][] jArray1 = new int[2][]; //it can include two single-dimensional array
            int[][,] jArray2 = new int[3][,]; // it can include Three two-dimensianl array

            jArray1[0] = new int[3] { 1, 2, 3 };
            jArray1[1] = new int[4] { 6, 7, 8, 9 };

            int[][] jArray3 = new int[2][]
            {
                new int[3] { 1, 2, 3 },
                new int[4] { 6, 7, 8, 9 }
            };

            //jArray3[1][1] => 7
            //jArray3[0][2] => 3


            //Indexer example
            StringDataStore dataStore = new StringDataStore();
            dataStore[0] = "One";
            dataStore[1] = "Two";
            dataStore[2] = "Three";
            dataStore[3] = "Four";

            Console.WriteLine();
            //for (int i=0; i< 5; i++)
            //{
            //    Console.WriteLine(dataStore[i]);
            //}

            //Console.WriteLine(dataStore["Two"]);


            //Tuple
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "reza", "sh");
            int id = person.Item1;
            string fname = person.Item2;
            string lname = person.Item3;

            DisplayTuple(person);

            var person2 = Tuple.Create(2, "John", "Wick");

            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7);
            int number7 = numbers.Item7;

            //Nested Tuple
            var numbers2 = Tuple.Create(1, 2, 3, 4, Tuple.Create(5, 6, 7, 8, 9));
            //numbers2.Item5.Item1; //=>5
            var numbers3 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(5, 6, 7, 8, 9));
            //numbers3.Rest.Item3 => 7


            var bobthesponge = GetPerson();


            //valuetuple
            ValueTuple<int, string, string> myperson1 = (1, "Tom", "hanks");
            (int, string, string) myperson2 = (1, "Tom", "hanks");
            //myperson2.Item1

            var numbers5 = (1, 2, 3, 4, 5, "F", 7, 8, "B", 10, "A");
            var pers = (Id: 1, FirstName: "Tom", lastName: "Cruise");

            string f_name = "Jack";
            string l_name = "Black";
            var JackPerson = (FirstName: f_name, LastName: l_name);
            //JackPerson.FirstName

            
        }

        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = {person.Item1}");
            Console.WriteLine($"first name = {person.Item2}");
            Console.WriteLine($"last name = {person.Item3}");
        }

        static void DisplayValueTuple((int, string, string) person)
        {
            Console.WriteLine($"Id = {person.Item1}");
            Console.WriteLine($"first name = {person.Item2}");
            Console.WriteLine($"last name = {person.Item3}");
        }

        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(2, "Bob", "the sponge");
        }
    }
}
