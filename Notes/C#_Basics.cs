using System;
namespace Test
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // console is a class 
            // Writeline is a method
            var FirstName = "kalpesh"; // var will detect all data types autmatically
            Console.WriteLine(FirstName);
            Console.WriteLine("Hello Bhau");

            // to see min/max range of Datatypes 
            Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue); 
            Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);

           // **************Type casting ***********************

            //Explicit conversion 
            float realNum = 1.2f;
            int Number = (int)realNum;
            Console.WriteLine(Number);

            //implicit  Conversion
            int number = 12;
            float FNum = number;
            Console.WriteLine(FNum);

            // Non Compatible Conversion
            string A = "1";
            int b = Convert.ToInt32(A); // int b = int.parse(A); another way 
            Console.WriteLine(b);

            //Conversions
            /*
                ToByte()
                ToInt16()
                ToInt32()
                ToInt64()
             */

            // Exception 

            try
            {
                var Num1 = "1234";
                byte B1 = Convert.ToByte(Num1);
                Console.WriteLine(B1);
            }
            catch (Exception)
            {
                Console.WriteLine("coversion will not happen ");
            }

            // ********** Operators *********

            /*
               Arithmatic { + , -, *, /, %, ++, -- }  incremenmt/ Decrement 
               Logical { &&, ||, ! }
               Bitwise { &, | }
               Comparion { ==, !=, >, <, >=, <= }
               Assignment { =, -=, +=, *=, /= }
             */

            //******************* String Methods ***********************
            var VarLenth = "kalpesh patil";

            Console.WriteLine("lenth of string "+VarLenth.Length); // {.Length} is used to cal the len of string
            Console.WriteLine("upper case"+VarLenth.ToUpper());// {.ToLower } used to lower/Upper the case
            Console.WriteLine(VarLenth.Contains("kalpesh"));// {.contains } used to check var contain the of string
            Console.WriteLine("at the index of 4 "+VarLenth[4]+" is present"); // get the Alph using index no
            Console.WriteLine("index of l is " + VarLenth.IndexOf('l')); // to get index no using Alph/string 
            Console.WriteLine(VarLenth.Substring(8)); // used print some part of string using index number

            //************* Numbers Methods   ********************
            Console.Clear();
            Console.WriteLine(Math.Abs(-40)); // used to give absolute value 
            Console.WriteLine(Math.Pow(3, 2)); // used to check power of some value 3^2 = 9  
            Console.WriteLine(Math.Sqrt(6)); // used to check squre root of value 
            Console.WriteLine(Math.Max(10, 2)); //{ min } used to check the minimum/maximum value of 2 num
            Console.WriteLine(Math.Round(3.2)); // used to give rount of value 3.2 = 4;


            //****** calling methods *************
            Array(); // calling function 
            Console.WriteLine(Cube(3)); 
        }
        static void Array()
        {
            //********** Array ********************
            Console.Clear();

            int[] RandomNumber = { 0, 1, 2, 3, 4, 5, };
            RandomNumber[2] = 200; 
            Console.WriteLine(RandomNumber[2]);

            string[] Friends = new string[5];
            Friends[0] = "max";
            Friends[1] = "min";
            Friends[2] = "hob";
            Friends[3] = "joy";
            Friends[4] = "tom";

            Console.WriteLine("My Best friend is " + Friends[1]);

        }
        static int Cube(int num1)
        {
            int Result = num1 * num1 * num1;
            return Result;
        }
    }
}
