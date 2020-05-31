using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HackerRankDay01_4
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> res = new List<int>();
            res.Add(0);
            res.Add(0);
            for (int i = 0; i < a.Count; i++)
            {
                _ = a[i] != b[i] ? a[i] > b[i] ? res[0]++ : res[1]++ : 0;
            }
            return res;
        }
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(string.Join(" ", result));

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();

        }
    }
}
