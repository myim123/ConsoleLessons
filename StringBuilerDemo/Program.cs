using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, "Hello World".Length);
            builder.AppendLine();
            builder.Insert(0, "Good Bye World");
            builder.AppendLine();
            builder.Insert(0, new string('-',10));
            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
