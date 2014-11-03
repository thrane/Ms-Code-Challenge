using System;

namespace FibonacciChallenge
{
    public class Challenge
    {
        /*
         * Write a method that returns any given number in the Fibonnacci sequence.
         * 0,1,1,2,3,5,8,13,21...
         */
		 
        public long Fib(int n)
        {
            var qrard5 = Math.Sqrt(5);
            return Convert.ToInt64((Math.Pow((1 + qrard5), n) - (Math.Pow((1 - qrard5), n))) / (Math.Pow(2, n) * qrard5));
            }
    }
}
