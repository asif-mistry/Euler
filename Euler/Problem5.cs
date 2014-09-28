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

            //getSmallestMultimple2();
            Console.WriteLine("\nResult ==" + getSmallestMultimple(1,20));
        }
        public long getSmallestMultimple (int smallestNumber, int largestNumber)
        {
            bool flag = false;
            int count = 0;//starting count from 1, as we are looking for smallest multiple
            while (flag == false)
            {
                count++;
                for (int i = smallestNumber; i <= largestNumber; i++)
                {                    
                    if (count%i!=0)
                    {
                        flag=false;
                        break;
                    }
                    else
                    {
                        flag=true;
                    }
                }
            }
            return count;
        }

        public void getSmallestMultimple2()
        { 
            int i = 1;
            for (; ; )
            {
                if (i % 1 == 0 && i % 2 == 0 && i % 3 == 0 && i % 4 == 0 && i % 5 == 0 && i % 6 == 0 &&
                    i % 7 == 0 && i % 8 == 0 && i % 9 == 0 && i % 10 == 0 && i % 11 == 0 &&
                    i % 12 == 0 && i % 13 == 0 && i % 14 == 0 && i % 15 == 0 && i % 16 == 0 &&
                    i % 17 == 0 && i % 18 == 0 && i % 19 == 0 && i % 20 == 0)
                {
                    Console.WriteLine("Result:"+ i);
                    break;
                }

                i++;
            }
        }
    }
}
