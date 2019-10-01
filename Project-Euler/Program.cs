using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Problem would you like to load? (One, two, etc)");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "one":
                    Problem1 problem = new Problem1();
                    problem.ProblemOne();
                    break;

                default:
                    Console.WriteLine("Input not recognised");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
