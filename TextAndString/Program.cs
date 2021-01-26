using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mike Yim ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());

            //Parse first and last name Method1
            Console.WriteLine("Parse using IndexOf method");
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First: " + firstName);
            Console.WriteLine("Last: " + lastName);

            //Parse first and last name Method2
            // using split method
            Console.WriteLine("Parse using Split method");
            var name = fullName.Split(' ');
            Console.WriteLine("First: " + name[0]);
            Console.WriteLine("Last: " + name[1]);

            //Replace
            var newName = fullName.Replace("Mike", "Mikey");
            Console.WriteLine(newName.ToString());
            var replaceName = fullName.Replace("M", "Y");
            Console.WriteLine(replaceName.ToString());
            Console.WriteLine(fullName.ToString());

            if (string.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //Convert string to number
            var strAge = "25";
            var age = Convert.ToByte(strAge);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

            //Summarizing text to less then the maxLength
            var sentence = "This is a really really really really really long sentence.";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);

        }

        
    }
}
    
