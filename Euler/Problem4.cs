﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Largest palindrome product
 * Problem 4
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 * Answers : 906609
 */ 
namespace Euler
{
    class Problem4
    {
        public void answerProblem()
        {
            //spuno();
            Console.WriteLine("\nResult ==" + getLargestPalindromeForNumberOfDigits(3));
        }

        //spuno's answer 
        public void spuno()
        {
            int sum;
            int Largest = -1;
            string res;
            bool Palindrome = true;

            for (int x = 999; x >= 1; x--)
            {
                for (int y = 999; y >= 1; y--)
                {
                    sum = x * y;
                    res = sum.ToString();
                    Palindrome = true;
                    for (int t = 0; t < res.Length / 2; t++)
                    {
                        if (res[t] != res[res.Length - t - 1]) Palindrome = false;
                    }
                    if (Palindrome) if (sum > Largest) Largest = sum;
                }
            }
            Console.WriteLine(Largest);
        }

        public long getLargestPalindromeForNumberOfDigits(int num)
        {
            long largestNumberFromDigits = getLargestNumberFromDigits(num);
            long largestMultiple = 0;
            for (long i = largestNumberFromDigits; i > 1; i--)
            {
                for (long j = largestNumberFromDigits; j > 1; j--)
                {
                    long largesMultipleTemp=i*j;
                    if (isPalindrome(largesMultipleTemp))
                    {
                        if (largesMultipleTemp > largestMultiple)
                        {
                            largestMultiple = largesMultipleTemp;
                            //Console.WriteLine("\nResult " + i + " * " + j + " Largest Multiple ==" + largesMultipleTemp);
                            break;
                        }
                    }
                }
            }

            return largestMultiple;
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
                num = num /10;
            }
            return digitsList;
        }

        public long getLargestNumberFromDigits(int digits)
        {
            long largestNumber = 9;

            for (int i = digits; i > 1; i--)
            {
                int d = 1;
                for (int j = 0; j < i-1; j++)
                    d = d * 10;
                
                largestNumber += 9 * d;
            }
            return largestNumber;
        }
    }
}
