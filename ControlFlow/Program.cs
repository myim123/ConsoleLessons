using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditional: if else
            //int hour = 10;
            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It's morning.");
            //else if  (hour >=12 && hour < 18)
            //    Console.WriteLine("It's evening.");
            //else
            //    Console.WriteLine("It's evening.");

            //bool isGoldCustomer = true;
            ////float price;
            ////if (isGoldCustomer)
            ////    price = 19.95f;
            ////else
            ////    price = 29.95f;

            ////if statment above can be re-written using conditional operator
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //Switch Case
            //var season = Season.Autumn;
            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("It's Spring." );
            //        break;
            //    case Season.Autumn:
            //    case Season.Summer:
            //        Console.WriteLine("It's Autumn/Summer.");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("It's Winter.");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown Season");
            //        break;
            //}

            //Iteration Statement

            //For Loop
            //output only even numbers
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (var i = 10; i >=1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Foreach loop
            //var name = "Mike Yim";
            //foreach (var str in name)
            //{
            //    Console.WriteLine(str);
            //}

            //var numbers = new int[] { 1, 2, 3, 4 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //While loop
            //var i = 0;
            //while ( i<=10)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //        break;
            //    Console.WriteLine("Echo: " + input);
            //}

            //Random
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1,10));
            //}

            //Random to generate characters
            //will generate random chars between 'a' and 'z'
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(97, 122));    // 97= 'a' 122 = 'z'
            //    Console.WriteLine();
            //}

            //easier way... cast number to a character
            //var random = new Random();
            //for (var i = 0; i < 10; i++)
            //    Console.Write((char)('a' + random.Next(0, 26)));
            //Console.WriteLine();

            //exercise:
            //autogenerate 10 chars password 
            const int passwordLength = 10;
            var random = new Random();
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
