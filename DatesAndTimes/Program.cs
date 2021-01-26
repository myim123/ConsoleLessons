using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Min: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString ());
            Console.WriteLine(now.ToShortDateString ());
            Console.WriteLine(now.ToShortTimeString ());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //Timespan
            var timespan = new TimeSpan(1, 2, 3);  //(h,m,s)
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = start - end;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Min: " + timespan.Minutes);
            Console.WriteLine("TotalMin: " + timespan.TotalMinutes);

            // Add
            Console.WriteLine("Add time: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add time: " + timespan.Subtract(TimeSpan.FromMinutes(8)));

            // ToString
            Console.WriteLine("ToString" + timespan.ToString ());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
