using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        class Result
        {

            /*
             * Complete the 'reverse' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING str as parameter.
             */

            public static string reverse(string str)
            {
                string res = string.Empty;
                //make an array of words
                string[] list = str.Split(' ');
                //reverse it
                Array.Reverse(list);
                //build new string
                res = string.Join(" ", list);
                //return
                return res;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                string str = Console.ReadLine();

                string result = Result.reverse(str);

                Console.WriteLine(result);

                Console.Write("\nPress any key to continue... ");
                Console.ReadLine();
            }

        }
        }
    }
