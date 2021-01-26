using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var testString = "kayak";
            
            if (IsPalindrome(testString))
                Console.WriteLine(testString + " is a Palindrome.");
            else
                Console.WriteLine(testString + " is not a Palindrome.");
        }

        public static bool IsPalindrome(string word)
        {
            var lenString = word.Length;
            var numIteration = lenString / 2;

            for (int i = 0; i <= numIteration; i++)
            {
                if (word[i] != word[lenString - i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
