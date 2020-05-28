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
            List<string> inputs = new List<string>();

            //Console.WriteLine("Enter number of cases");
            int.TryParse(Console.ReadLine(), out int _cases);
            if ((_cases < 1) || (_cases > 20))
            {
                Console.WriteLine("Invalid input: number of cases");
                WaitAndClose();
                return;
            }
            #region create list of inputs
            for (int i = 0; i < _cases; i++)
            {
                //Console.WriteLine("Enter a string #{0}:", i + 1);
                string _temp = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(_temp) || ((_temp.Length < 1) || (_temp.Length > 100005)))
                {
                    Console.WriteLine("Please re-enter a string #{0}:", i);
                    i--;
                }
                else
                {
                    inputs.Add(_temp);
                }
            }
            #endregion
            #region compute cases
            //int _count = 1;
            List<int> res = new List<int>();
            foreach (string StrToCompute in inputs)
            {
                res.Clear();
                //Console.WriteLine("case {0}:", _count++);
                if (IsPolydrome(StrToCompute))
                {
                    res.Add(-1);
                    Console.WriteLine(res[0].ToString());
                    continue;
                }

                for (int i = 0; i < StrToCompute.Length; i++)
                {
                    if (IsPolydrome(StrToCompute.Remove(i, 1)))
                    {
                        res.Add(i);
                    }
                }

                foreach (int item in res)
                {
                    Console.WriteLine(item.ToString());
                }
            }//foreach (string StrToCompute in inputs
            #endregion

            WaitAndClose();
        }

        static bool IsPolydrome(string s)
        {
            bool res;
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            string rev = new string(array);
            res = string.Equals(s, rev);
            return res;
        }

        static void WaitAndClose()
        {
            //Console.Write("\nPress any key to continue... ");
            //Console.ReadLine();
        }

    }
}
