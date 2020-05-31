using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay01_6
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int res = 0;
            bool found = true;
            while (found)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] != -1)
                    {
                        for (int j = i + 1; j < ar.Length; j++)
                        {
                            if (ar[j] == ar[i])
                            {
                                ar[j] = -1;
                                ar[i] = -1;
                                res++;
                                i = 0;
                                break;
                            }
                        }
                    }
                    found = false;
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
