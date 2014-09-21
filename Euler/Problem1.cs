using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Multiples of 3 and 5
Problem 1
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
 * 
 * Answer : 233168
*/
namespace Euler
{
    class Problem1
    {

        public void answerProblem1()
        {

            int n = 1000;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }


            Console.WriteLine("Result ==" + result);



        }


    }
}
