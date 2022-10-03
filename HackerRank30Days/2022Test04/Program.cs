using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022Test04
{
    internal class Result
    {
        /*
 * Complete the 'staircase' function below.
 *
 * The function accepts INTEGER n as parameter.
 */

        public static void staircase(int n)
        {
            for (int i = n; i > 0; i--)
            {
                string s = string.Concat(Enumerable.Repeat("#", n - i + 1)).PadLeft(n);
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of stairs:\n");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            staircase(n);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
