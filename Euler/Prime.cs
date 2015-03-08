using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Better implementation of prime numbers
 * Check http://en.wikipedia.org/wiki/Primality_test for details 
 */ 

namespace Euler
{
    class Prime
    {
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
