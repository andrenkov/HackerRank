using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}",n, i, n*i));
            }
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
