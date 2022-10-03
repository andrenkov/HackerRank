using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnetForensics
{
    using System;
    using System.IO;

    class Solution
    {
        public static string Run(string filePath)
        {
            string res = "";
            //Path.AltDirectorySeparatorChar = '\\';
            //Path.DirectorySeparatorChar

            //Solution #1
            //res = Directory.GetParent(filePath) == null ? "not found" : Directory.GetParent(filePath).Name;

            //Solution #2
            //List<string> pathparts = @filePath.Split('\\').ToList();
            //res = pathparts[pathparts.Count-2];

            //Solution #3
            //List<string> pathparts = @filePath.Split(Path.DirectorySeparatorChar).ToList();
            //res = pathparts[pathparts.Count-2];

            //Solution #4
            DirectoryInfo di = new DirectoryInfo(filePath);
            res = di.Parent.Name;

            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your file name\n");
            string filepath = Console.ReadLine();

            filepath = "C:\\foo\\bar\\file.txt";//bar
            //filepath = "C:\\foo\\bar\\..\\folder\\..\\..\\file.txt";//C
            //filepath = "C:\\foo\\bar\\..\\file.txt";
            filepath = @"C:\foo\bar\..\folder\..\..\file.txt";

            Console.WriteLine(Solution.Run(filepath));

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}



