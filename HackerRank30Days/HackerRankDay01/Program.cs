using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare second integer, double, and String variables.
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Read and save an integer, double, and String to your variables.
            int ii = Convert.ToInt32(Console.ReadLine());
            double dd = Convert.ToDouble(Console.ReadLine());
            string ss = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine((i+ii).ToString());

            // Print the sum of the double variables on a new line.
            Console.WriteLine((d+dd).ToString("F1"));

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + ss);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
