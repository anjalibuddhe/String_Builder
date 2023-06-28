using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(20);

            StringBuilder str1 = new StringBuilder("hello to all", 20);

            str.Append(str1);
            Console.WriteLine( str);

            str.Insert(5, "we are learning c#");
            Console.WriteLine( str);

            str.Remove(4, 5);
            Console.WriteLine(str);
            
            StringBuilder str3 = new StringBuilder("amount is");

            str3.AppendFormat("{0:C} ", 50);
            Console.WriteLine(str3);

            StringBuilder str4 = new StringBuilder("hello To All");
            str4.Replace("hello", "Hello");
            Console.WriteLine(str4);


            str.AppendLine("new learner");
            Console.WriteLine(str);
        }
    }
}
