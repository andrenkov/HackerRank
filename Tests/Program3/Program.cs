using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        // Complete the common function below.
        static string common(string str1, string str2)
        {
            string res = string.Empty;
            foreach (char item in str1)//loop through the string and copy all common chars
            {
                if (str2.Contains(item) && (res.IndexOf(item) == -1))//check if character is present in both and not already in the result str 
                {
                    res += item;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string res = common(str1, str2);
            Console.WriteLine(res);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
