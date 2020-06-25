using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)//odd number
            {
                Console.WriteLine("Weird");
            }

            if ((N % 2 == 0) && (2 <= N && N <= 5))//even number
            {
                Console.WriteLine("Not Weird");
            }

            if ((N % 2 == 0) && (6 <= N && N <= 20))//even number
            {
                Console.WriteLine("Weird");
            }
            if ((N % 2 == 0) && (N > 20))//even number
            {
                Console.WriteLine("Not Weird");
            }


            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
