using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay03_2
{
    class Program
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double cost = meal_cost + meal_cost * ((double)tip_percent / 100) + meal_cost * ((double)tax_percent / 100);
            Console.WriteLine(Math.Round(cost).ToString());
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);

            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();
        }
    }
}
