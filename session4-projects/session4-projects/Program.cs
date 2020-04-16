
using MyExtensionMethods;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace session4_projects
{
    class Program
    {
        public delegate void Print(int value);

        delegate bool IsHeYoung(Student s);

        static void Main(string[] args)
        {
            int i = 10;
            Print print = delegate (int value)
            {
                value += i; // Access to the outer function
                //Console.WriteLine("Inside annonymouse method. value {0}", value);
            };

            print(1000);

            PrintHelperMethod(delegate (int val)
                {
                    //Console.WriteLine("Inside annonymouse method. value {0}", val);
                }, 200
            );

            Print printFoo = delegate (int valuex)
            {
                valuex = valuex * 1000;

                //Console.WriteLine(valuex);
            };
            printFoo(200);



            //delegate 
            IsHeYoung young = delegate (Student s)
            {
                return s.age > 20 && s.age < 40;
            };

            //Lambda expression
            IsHeYoung young2 = st => st.age > 20 && st.age < 40;

            //Nullable example
            Nullable<Int32> nullVar = null;

            //This will throw null pointer exception
            //Console.WriteLine(nullVar.Value);

            if (nullVar.HasValue)
            {
                //Console.WriteLine(nullVar.Value);
            }
            else
            {
                //Console.WriteLine("Null");
            }

            //Console.WriteLine(nullVar.GetValueOrDefault());


            //Nullable shorthand
            int? i1 = null;
            double? D = null;

            int? j = null;
            int k = j ?? 0;

            Console.WriteLine(k);

            List<int> numbers = null;
            (numbers ??= new List<int>()).Add(5);
            
            int? a = null;
            numbers.Add(a ??= 0);

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            int? var1 = 6;
            int var2 = 10;


            if(var1 > var2)
            {
                Console.WriteLine("1");
            }
            if (var1 < var2)
            {
                Console.WriteLine("2");
            }
            if (var1 == var2)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("None of those");
            }

          
            if(Nullable.Compare<int>(var1, var2) < 0)
            {
                Console.WriteLine("var1 < var2");
            }
            else if (Nullable.Compare<int>(var1, var2) > 0)
            {
                Console.WriteLine("var1 > var2");
            }
            else
            {
                Console.WriteLine("var1 = var2");
            }

            //Predicate
            //I need to pass a delegate with a method
            Predicate<string> isLower = IsUpperCase;

            //with an anonymous method
            Predicate<string> isUpper = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };

            //lambda 1
            Predicate<string> isUpper2 = st => 
            {
                return st.Equals(st.ToUpper());
            };

            //lambda shorter
            Predicate<string> isUpper3 = st => st.Equals(st.ToUpper());
            

            bool result1 = isUpper("HELLO");
            bool result2 = isUpper2("HELLO");
            bool result3 = isUpper3("HELLO");


            //Extension methods
            int ii = 10;
            string fooTest = "Foo";
            bool result_greaterthan = ii.IsGreaterThan(100);
            bool result_smallerthan = ii.IsSmallerThan(100);
            bool result_foo_check = fooTest.IsStringIsFoo("Foo");
            

            Console.WriteLine(result_greaterthan);
            Console.WriteLine(result_smallerthan);
            Console.WriteLine(result_foo_check);

            //static classes in c# gives some facilites
            string fileName = @"c:\Temp\reza.txt";
            string fileName2 = @"c:\Temp\reza2.txt";



            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                //streams can be connection to database or file operations
                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text file \n");
                    fs.Write(title, 0, title.Length);                    
                    byte[] author = new UTF8Encoding(true).GetBytes("Reza");
                    fs.Write(author, 0, author.Length);
                }

                String dummyLines = "this is the firstLine" + Environment.NewLine +
                                    "this is the second line" + Environment.NewLine +
                                    "this is the third line" + Environment.NewLine;
                File.AppendAllLines(fileName, dummyLines.Split(
                    Environment.NewLine.ToCharArray()));

                File.AppendAllText(fileName, "this is a test");

                File.Copy(fileName, fileName2);

                

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string st = "";
                    while((st = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(st);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }



            //FileInfo
            FileInfo fileInfo = new FileInfo(fileName);
            FileStream fsInfo = fileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            byte[] filebytes = new byte[fsInfo.Length];

            int numBytesToread = filebytes.Length;
            int numBytesRead = 0;

            while (numBytesToread > 0)
            {
                int n = fsInfo.Read(filebytes, numBytesRead, numBytesToread);

                if(n == 0)
                {
                    break;
                }

                numBytesRead += n;
                numBytesToread -= n;
            }

            StreamReader srInfo = new StreamReader(fsInfo);

            string fileContent = srInfo.ReadToEnd();




            FileInfo fileInfo3 = new FileInfo(fileName);


            StreamWriter sw = new StreamWriter(fsInfo);
            sw.Write("my test");

            //since I didn't use using
            sw.Close();
            srInfo.Close();
            fsInfo.Close();

            sealedTest test = new sealedTest();
            test.getType();
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }


    }




    public class Student
    {
        public int age;
    }
}

