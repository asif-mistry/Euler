using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Largest prime factor
 * Problem 3
 * The prime factors of 13195 are 5, 7, 13 and 29.

 * What is the largest prime factor of the number 600851475143 ?
 * 
 * Answer : 6857
 */
namespace Euler
{
    class Problem3
    {
        long largestPrime = 1;
        //string s = "";
        public void answerProblem()
        {
            long n = 600851475143;//four million 4 000 000 
            getPrimeFactor(n);

            Console.WriteLine("\nResult ==" + largestPrime);
        }

        public long getPrimeFactor(long num)
        {

            if (isPrime(num))
            {
                if (num > largestPrime)
                    largestPrime = num;
                return num;
            }
            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    long divider = num / i;
                    
                    largestPrime = i;
                    getPrimeFactor(divider);
                    getPrimeFactor(i);
                    return 0;
                }
            }
            return 0;
        }

        public bool isPrime(long num)
        {
            if (num == 2)
                return true;

            for (long i = 3; i < num/2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
