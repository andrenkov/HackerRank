using System;
using System.Collections.Generic;
using System.Linq;

namespace _2022Test01
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long maxNum = arr[0];
            long minNum = arr[0];
            long Sum = 0;

            foreach (var item in arr)
            {
                Sum += item;
                if (item < minNum)
                    minNum = item;
                if (item > maxNum)
                    maxNum = item;
            }
            Console.WriteLine(string.Format("{0} {1}", Sum - maxNum, Sum - minNum));
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }

}
