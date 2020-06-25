using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay06_1
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0; i < list.Count; i++)
            {
                string odd = string.Empty;
                string even = string.Empty;
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        odd += list[i][j];
                    }
                    else
                    {
                        even += list[i][j];
                    }
                }
                Console.WriteLine(string.Format("{0} {1}", odd, even));
            }

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
