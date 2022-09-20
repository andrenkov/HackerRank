using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        int res = 0;
        int tolest = candles[0];

        foreach (var item in candles)
        {
            if (item == tolest)
            {
                res++;
            }
            else
            {
                if (item > tolest)
                {
                    tolest = item;
                    res = 1;
                }
            }
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(Environment.CurrentDirectory, true);
        //TextWriter textWriter = new StreamWriter(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();

        Console.Write("\nPress any key to continue... ");
        Console.ReadLine();
    }
}

