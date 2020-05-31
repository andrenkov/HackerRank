using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay01_5
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            double _size = arr.Length;
            int _positive = 0;
            int _negative = 0;
            int _zero = 0;

            foreach (int item in arr)
            {
                switch (item == 0)
                {
                    case true: _zero++;
                    break;
                    default:
                        _ = item > 0 ? _positive++ : _negative++;
                        break;
                }
            }

            Console.Write((_positive / _size).ToString("F6"));
            Console.Write("\n" + (_negative / _size).ToString("F6"));
            Console.Write("\n" + (_zero / _size).ToString("F6"));

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            plusMinus(arr);
        }
    }
}
