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
            long n = 600851475143111;//four million 4 000 000 
            //bool isPali= isPalindrome(n);

            //Console.WriteLine("\nResult ==" + isPali);
        }
        public bool isPalindrome(long num)
        {
            List<long> digitLists = getDigitsList(num);
            bool isEven=false;
            if ((digitLists.Count) % 2 == 0)
                isEven = true;

            if (isEven)
            {

            }

            List <int> integerList = new List <int> (); 
            //To iterate on items contained in the list, use the foreach operator :
            foreach(int i in integerList) 
            { // do stuff with i 
            }
            //You can add items in the list object with Add() and Remove() functions.
            for(int i = 0; i < 10; i++) 
            {
                integerList.Add(i); 
            } 
            integerList.Remove(6); 
            integerList.Remove(7);
            //You can convert a List<T> to an array using the ToArray() function :
            
            int[] integerArray = integerList.ToArray(); 
            if (num == 2)
                return true;

            for (long i = 3; i < num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public int getDigitCount(long num)
        {
            int digitCount=0;
            while (num>0)
            {
                num = num / 10;
                digitCount++;
            }
            return digitCount;
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
