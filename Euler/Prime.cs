﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Better implementation of prime numbers
 * Check http://en.wikipedia.org/wiki/Primality_test for details on IsPrime
 * 
 * The Prime list is obtained by following Sieve Of Eratosthenes Algorithm
 * 
 * The algorithm:
 * 
 * Build a list of all the integers greater than one and less than or equal to n.
 * Strike out the multiples of all primes less than or equal to the square root of n,
 * then the numbers that are left are the primes.
 * 
 * Check http://www.scriptol.com/programming/sieve.php for details. DO NOT USE the C# implementation as its incorrect and too time consuming. I am using the Java implementation.
 */

namespace Euler
{

    class Prime
    {
        public static List<ulong> getPrimeList(ulong num)
        {            
            bool[] primeList = new bool[num+1];
            for (ulong i = 2; i <= num; i++)
                primeList[i] = true;
            
            for (ulong i = 2; i*i <= num; i++)
            {
                if (primeList[i])
                {
                    for (ulong j = i; i*j <= num; j++)
                        primeList[i*j] = false;
                }
            }
            List<ulong> listOfPrimes = new List<ulong>();
            for (ulong i = 2; i <= num; i++)
            {
                if (primeList[i])
                {
                    listOfPrimes.Add(i);
                }
            }

            return listOfPrimes;
        }
         
        public static bool isPrime(ulong num)
        {
            if (num < 3)
                return num > 1;
            else if (num % 2 == 0 || num % 3 == 0)
                return false;
            
            ulong sqaureroot = Convert.ToUInt64(Math.Sqrt(num));
            for (ulong i = 5; i <= sqaureroot; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
            return true;
        }
    }
}
