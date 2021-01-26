using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //================================================================
            //Array
            //================================================================
            //var numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            ////Length
            //Console.WriteLine("Length: " +numbers.Length);

            ////IndexOf
            //var index =Array.IndexOf(numbers, 9);
            //Console.WriteLine("index of 9 is:" + index);

            ////Clear
            ////clear 2 elements starting index 0
            //Console.WriteLine();
            //Console.WriteLine("Before Clear()");
            //OutputArrayToConsole(numbers);

            //Array.Clear(numbers, 0, 2);
            //Console.WriteLine("Effect of Clear()");
            //OutputArrayToConsole(numbers);

            //// first two elements are cleared = 0

            //// Copy
            //Console.WriteLine();
            //var another = new int[3];
            //Console.WriteLine("Effects of copy");
            //Array.Copy(numbers, another, 3);
            //OutputArrayToConsole(another);


            //// Sort
            //Console.WriteLine();
            //Console.WriteLine("Before sort");
            //OutputArrayToConsole(numbers);
            //Array.Sort(numbers);
            //Console.WriteLine("Effects of sort");
            //OutputArrayToConsole(numbers);

            //// ReverseS
            //Console.WriteLine();
            //Console.WriteLine("Before reverse");
            //OutputArrayToConsole(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine("Effects of reverse");
            //OutputArrayToConsole(numbers);


            //================================================================
            // List         var numbers = new List<int>()
            //================================================================
            var numbers = new List<int>() { 1, 9, 13, 4, 3, 6 };
            OutputListToConsole(numbers);
            Console.WriteLine("List count: " + numbers.Count);
            numbers.Add(2);
            numbers.AddRange(new int[3] { 5, 7, 9 });
            OutputListToConsole(numbers);
            Console.WriteLine("List count: " + numbers.Count);
            Console.WriteLine("Index of 9 is " + numbers.IndexOf(9));
            Console.WriteLine("Last Index of 9 is " + numbers.LastIndexOf(9));
            Console.WriteLine("List Count: " + numbers.Count);
            numbers.Remove(1);
            OutputListToConsole(numbers);

            Console.WriteLine("List count: " + numbers.Count);
            if (numbers.Contains(5))
                Console.WriteLine("5 is in the list");
      
            numbers.Clear();
        }

        static void OutputArrayToConsole( int[] arry )
        {
            foreach (var number in arry)
                Console.Write(number);
            Console.WriteLine();
        }

        static void OutputListToConsole( List<int> numbersList)
        {
            foreach (var number in numbersList)
                Console.Write(number);
            Console.WriteLine();
        }
    }
}
