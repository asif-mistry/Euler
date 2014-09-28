using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 10001st prime
 * Problem 7
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * 
 * What is the 10 001st prime number?
 * 
 */
namespace Euler
{
    class Problem7
    {
        public void answerProblem()
        {
            Console.WriteLine("\nResult ==" + getPrimeForPosition(6));
        }

        public long getPrimeForPosition(long position)
        {
            long nThPrime = 2;

            long foundPrimeCount = 0;

            long i = 2;
            while (foundPrimeCount <= position)
            {
                if (Problem3.isPrime(i))
                {
                    foundPrimeCount++;

                    if (i > nThPrime)
                        nThPrime = i;
                }
                i++;
            }

            return nThPrime;
        }


    }
}
