using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Summation of primes
 * Problem 10
 * 
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * 
 * Find the sum of all the primes below two million.
 * 
 * 
 * 
 */

namespace Euler
{
    class Problem10
    {

        public void answerProblem()
        {
            ulong num = 2000000;//two million

            List<ulong> listOfPrimes = new List<ulong>();

            listOfPrimes = Prime.getPrimeList(num);
            
            ulong sum = 0;
            foreach (ulong i in listOfPrimes)
                sum += i;

            Console.WriteLine("\nProblem 10 Result == " + sum);
        }

    }
}
