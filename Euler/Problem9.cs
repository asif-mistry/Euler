using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Special Pythagorean triplet
 * Problem 9
 * 
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 * a2 + b2 = c2
 * 
 * For example, 32 + 42 = 9 + 16 = 25 = 52.
 * 
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * 
 * Find the product abc.
 * 
 * Answer : 31875000
 * 
 */
namespace Euler
{
    class Problem9
    {
        int answer = 0;
        public void answerProblem()
        {
            int num = 1000;

            List<int> naturalSquareRoot = new List<int>();

            for (int i = 1; i <= num-2; ++i)
            {
                for (int j = 1; j <= num - i; ++j)
                {
                    for (int k = 1; k <= num - i - j; ++k)
                    {
                        if (i + j + k == num)
                        {
                            checkPythagoreanTriplet(i, j, k);
                        }
                        else if (i + j + k > num)
                            Console.WriteLine("\n i=" + i + " j =" + j + " k=" + k);//To check that there are no excessive loop calls
                    }
                }
            }

            Console.WriteLine("\nProblem 9 Result == " + answer);
        }

        public void checkPythagoreanTriplet(int a, int b, int c)
        {
            //sort the numbers
            List<int> naturalSquareRoot = new List<int>();
            naturalSquareRoot.Add(a);
            naturalSquareRoot.Add(b);
            naturalSquareRoot.Add(c);

            naturalSquareRoot.Sort();

            a = naturalSquareRoot[0];
            b = naturalSquareRoot[1];
            c = naturalSquareRoot[2];

            //square the numbers
            long aSquare = a * a;
            long bSquare = b * b;
            long cSquare = c * c;

            //Check if a, b, c are pythagorean triplet 
            //i.e. :-   a^2 + b^2 = c^2 
            if (cSquare == (aSquare + bSquare))
            {
                answer = (a * b * c);
            }
        }
        /*
        public List<int> getNauturalNumbersWithePerfectSquaresBelow(int num)
        {
            List<int> nauturalNumbersWithePerfectSquares = new List<int>();

            for (int i = 1; i <= num; ++i)
            {
                int square = i*i;
                if (square%
            }


            return nauturalNumbersWithePerfectSquares;
        }*/
    }
}