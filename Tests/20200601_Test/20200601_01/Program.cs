using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution01
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int res = 0;
            int d = 0;
            int u = 0;
            bool passsealevel;

            for (int i = 0; i < s.Length; i++)
            {
                _ = s[i] == 'U' ? u++ : d++;
                passsealevel = u == d;

                if ((s[i] == 'U') && passsealevel)
                {
                    res++;
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
