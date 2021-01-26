using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Procedural Programming Demo
// Get Input string and return reversed string

namespace ProcedureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name? ");
            var name = Console.ReadLine();

            var reversedName = ReverseString(name);
            
            Console.WriteLine("Reversed name: " + reversedName);

        }
        public static string ReverseString(string name)
        {
            // create array wiht name.length dimension
            var array = new char[name.Length];
            // check each letters in the name starting from back
            // write to the array
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            //cast array to string
            var reversed = new string(array);
            return reversed;
        }
    }
    

}
