namespace SumSquareDifferenceChallenge
{
    using System;

    //The sum of the squares of the first ten natural numbers is,
    //      1^2 + 2^2 + ... + 10^2 = 385

    //The square of the sum of the first ten natural numbers is,
    //      (1 + 2 + ... + 10)^2 = 55^2 = 3025

    //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

    public class Challenge
    {
        public long Execute(int x)
        {
            long squareSum = (long) (Math.Pow(x, 3)/3 + Math.Pow(x, 2)/2 + (double)x/6);

            int sumForSquare = 0;
            for (int i = 0; i <= x; i++)
            {
                sumForSquare += i;
            }

            long sumSquare = (long) Math.Pow(sumForSquare, 2);

            return sumSquare - squareSum;
        }
    }
}
