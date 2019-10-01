using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem1
    {
        //Multiples of 3 and 5
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        public void ProblemOne()
        {
            int sum = 3;
            for (int i = 5; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Clipboard.SetText(sum.ToString());
            Console.WriteLine(sum.ToString());
            Console.ReadLine();
        }
    }
}
