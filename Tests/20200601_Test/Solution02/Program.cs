using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution02
{
    class Program
    {
        static List<string> res = new List<string>();
        static void minimumBribes(int[] q)
        {
            int size = q.Length;
            List<int> attempts = new List<int>();

            int[] orig = new int[q.Length];
            q.CopyTo(orig, 0);
            Array.Sort(orig);
            Console.WriteLine("{0}", string.Join("", orig));


            for (int i = q.Length; i >= 0; i--)
            {
            }


            res.Add("\nToo chaotic");
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }

            foreach (string item in res)
            {
                Console.Write(item);
            }

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
