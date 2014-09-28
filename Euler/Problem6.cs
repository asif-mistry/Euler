using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Sum square difference
 * Problem 6
 * The sum of the squares of the first ten natural numbers is,
 * 1 raised to 2 + 2 raised to 2 + ... + 10 raised to 2 = 385
 * 
 * The square of the sum of the first ten natural numbers is,
 * (1 + 2 + ... + 10) raised to 2 = 552 = 3025
 * 
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
 * 
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 * 
 * Answer : 25164150
*/
namespace Euler
{
    class Problem6
    {
        int firstNaturalNumbers = 100;//first ten natural numbers

        long sumOfSquares = 0;
        long squareOfSum = 0;

        public void answerProblem()
        {
            Console.WriteLine("\nResult ==" + getDelta());
        }

        public long getDelta ()
        {
            long delta = 0;
            getSumOfSquaresAndSquareOfSum();
            delta = squareOfSum - sumOfSquares;
            return delta;
        }

        public void getSumOfSquaresAndSquareOfSum()
        {
            for (int i = 1; i <= firstNaturalNumbers; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;
        }
    }
}
