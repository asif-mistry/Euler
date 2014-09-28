using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euler;
/*
 * UName: Asif178
 * Password: 13254678
 * https://projecteuler.net/problem=1
 */
namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem4 p = new Problem4();

            DateTime d = DateTime.Now;
            Console.WriteLine("Time started ==" + d);
            p.answerProblem();
            //bool b = p.isPrime(99);
            //Console.WriteLine(b);
             //b = p.isPrime(103);

             //Console.WriteLine(b);
            TimeSpan t = d - DateTime.Now;
            Console.WriteLine("Time taken =="+t);

            Console.ReadLine();

        }
    }
}
