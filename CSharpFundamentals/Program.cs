using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
   
    class Program
    {
        static void Main(string[] args)
        {

            //Class Demo
            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);

            //Array
            //int[] numbers = new int[3];  // = var numbers = new int[3];
            //numbers[0] = 1;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;
            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "Jack", "John", "Mike" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //String
            //string firstName = "Mike";
            //string lastName = "Yim";
            //var fullName = firstName + " " + lastName;
            //var myfullName = string.Format("My naem is {0} {1}", firstName, lastName);

            //var names = new string[3] { "John", "Jack", "Mary" };
            //var formattedName = string.Join(",", names);
            //Console.WriteLine(formattedName);

            //Verbatim Sting
            //var text = "c:\\apex\\expcash\\expcash.exe";
            //Console.WriteLine(text);

            //var text1 = @"c:\apex\expcash\expcash.exe";
            //Console.WriteLine(text1);

            //enum
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);    //cast methodid to ShippingMethod

            //Console.WriteLine(method.ToString());

            //var methodName = "Express";
            //var shippingMethod =(ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            //Console.WriteLine(shippingMethod.ToString());


            //Value Type & Reference Type
            //value Type
            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // Reference Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //both array1[0] and array2[0] is 0
            Console.WriteLine(string.Format("array1: {0}, array2 {1}", array1[0], array2[0]));


        }

        //public static void Increment(int number)
        //{
        //    number += 10;
        //}

        //public static void MakeOld(Person person)
        //{
        //    person.Age += 10;
        //}


        public enum ShippingMethod
        {
            RegularAirMail =1,
            RegisteredAirMail =2,
            Express=3
        }

    }


    //public class Person
    //{
    //    public int Age;
    //}

}
