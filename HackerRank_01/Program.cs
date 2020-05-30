using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_01
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            string _polydrome = Console.ReadLine();

            Console.WriteLine(res.ToString());

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
            
            List<int> res = new List<int>();
            foreach (var item in res)
            {

            }

            for (int i = 0; i < res.Count; i++)
            {

            }

            while (true)
            {

            }
        }
        */

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int T);
            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine().ToLower();
                if (IsPolydrome(s))
                {
                    Console.WriteLine("-1");
                    continue;
                }
                int _size = s.Length;
                for (int j = 0; j < _size - 1; j++)
                {
                    if ((s[j] != s[_size - (j+1)]) && (s[j+1] == s[_size - (j+1)]))
                    {
                        Console.WriteLine(j);
                        break;
                    }
                    if ((s[j] != s[_size - (j + 1)]) && (s[j] == s[_size - (j + 2)]))
                    {
                        Console.WriteLine(_size - (j + 1));
                        break;
                    }
                }
            }//for (int i = 0; i < T; i++)
            //WaitAndClose();
        }

        static bool IsPolydrome(string s)
        {
            //bool res;
            //char[] array = s.ToCharArray();
            //Array.Reverse(array);
            //string rev = new string(array);
            //res = string.Equals(s, rev);
            //return res;

            for (int i = 0; i < Convert.ToInt32(s.Length / 2); i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void WaitAndClose()
        {
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }

    }
}
