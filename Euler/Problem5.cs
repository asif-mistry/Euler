using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Smallest multiple
 * Problem 5
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * 
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 * 
 * Answer : 232792560
 */
namespace Euler
{
    class Problem5
    {
        public void answerProblem()
        {
            Console.WriteLine("\nResult ==" + getSmallestMultimple(1,20));
        }
        public long getSmallestMultimple (int smallestNumber, int largestNumber)
        {
            int smallestMultiple = 0;
            int count = 0;//starting count from 1, as we are looking for smallest multiple
            while (smallestMultiple == 0)
            {
                count++;
                for (int i = smallestNumber; i <= largestNumber; i++)
                {                    
                    if (count%i!=0)
                    {
                        smallestMultiple=0;
                        break;
                    }
                    else
                    {
                        smallestMultiple=count;
                    }
                }
            }
            return smallestMultiple;
        }
    }
}
