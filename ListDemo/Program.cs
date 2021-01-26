using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 7, 3, 4, 5, 6 };

            // Method 1 using sort method
            //var smallests = GetSmallestBySort(numbers, 2);
            // Output Method1 using string.join
            //Console.WriteLine(string.Join(",", smallests));

            // Method 2 Created by Mosh without using sort method
            //var smallests = GetSmallests(numbers, 3);
            // Output Method2 using foreach loop
            //foreach (var number in smallests)
            //    Console.WriteLine(number);

            // Method 3 without using the sort method
            var smallests = GetSmallestWithOutSort(numbers, 3);
            Console.WriteLine(string.Join(",", smallests));
        }

        //// Method 2 Created by Mosh
        //public static List<int> GetSmallests(List<int> list, int count)
        //{
        //    var smallests = new List<int>();

        //    while (smallests.Count < count)
        //    {
        //        var min = GetSmallest(list);
        //        smallests.Add(min);
        //        list.Remove(min);
        //    }
        //    return smallests;
        //}

        //public static int GetSmallest(List<int> list)
        //{
        //    //Assume the first number is the smallest
        //    var min = list[0];
        //    for (var i=1; i< list.Count; i++)
        //    {
        //        if (list[i] < min)
        //            min = list[i];

        //    }
        //    return min;
        //}

        public static List<int> GetSmallestWithOutSort(List<int> list, int numsToReturn)
        {
            var numbers = new List<int>(list);
            var smallestNumbers = new List<int>();
            var numOfSmallNumersToGet = 3;
            for (int i = 0; i < numOfSmallNumersToGet; i++)
            {
                var smallNumer = FindSmallesNumber(numbers);
                smallestNumbers.Add(smallNumer);
                numbers.Remove(smallNumer);
            }
            return smallestNumbers;
        }

        public static int FindSmallesNumber(List<int> list)
        {
            var smallNumer = list[0];
            foreach (var number in list)
            {
                //assume 1st number to be smallest
                //loop to compare all numbers in the list
                
                if (number <= smallNumer)
                {
                    smallNumer = number;
                }
            }
            return smallNumer;
        }
        public static List<int> GetSmallestBySort(List<int> list, int count)
        {
            list.Sort();
            var smallestNumbers = new List<int>();
            for (var i = 0; i <= count-1; i++)
            {
                smallestNumbers.Add(list[i]);
            }
            return smallestNumbers;
        }
    }
}
