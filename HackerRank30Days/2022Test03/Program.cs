using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        bool isPm = s.Substring(s.Length - 2).ToLower() == "pm";
        s = s.Substring(0, s.Length - 2);

        List<int> parts = s.Split(':').ToList().Select(partsTemp => Convert.ToInt32(partsTemp)).ToList();

        if (isPm)
        {
            if (parts[0] != 12)
            {
                parts[0] = parts[0] + 12;
            }
        }
        else//am
        {
            if (parts[0] == 12)
            {
                parts[0] = 0;
            }
        }

        string hours = parts[0].ToString();
        string mins = parts[1].ToString();
        string secs = parts[2].ToString();

        if (parts[0] < 10)
        {
            hours = "0" + parts[0].ToString();
        }
        if (parts[1] < 10)
        {
            mins = "0" + parts[1].ToString();
        }
        if (parts[2] < 10)
        {
            secs = "0" + parts[2].ToString();
        }

        return String.Format("{0}:{1}:{2}", hours, mins, secs);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        Console.Write("\nPress any key to continue... ");
        Console.ReadLine();
    }
}

