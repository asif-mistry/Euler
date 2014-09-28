using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Largest palindrome product
 * Problem 4
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */ 
namespace Euler
{
    class Problem4
    {
        int numberOfDigits=2;
        int largestNumberFromDigits = 99;

        public void answerProblem()
        {
            long n = 80177108;// 600851475143111;//four million 4 000 000 
            bool isPali= isPalindrome(n);

            Console.WriteLine("\nResult ==" + isPali);
        }
        public bool isPalindrome(long num)
        {
            List<long> digitsList = getDigitsList(num);
            int digitsCount = digitsList.Count;
            for(int i = 0; i < digitsCount/2; i++) 
            {
                if (!(digitsList[i] == digitsList[digitsCount - i-1]))
                {
                    return false;
                }
            }
            return true;
        }
        public List<long> getDigitsList(long num)
        {
            List<long> digitsList = new List<long>();
            while (num > 0)
            {
                long lastDigit =(long) num % 10;
                digitsList.Add(lastDigit);

                //Console.WriteLine("" + lastDigit);
                num = num /10;
            }
            return digitsList;
        }
    }
}
