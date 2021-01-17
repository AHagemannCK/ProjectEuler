using System;

namespace ProjectEuler.NetCore.CSharp
{
    public static class Problem3
    {
        public static void Solve()
        {
            var largestPrimeFactor = GetLargestPrimeFactor(600851475143);
            Console.WriteLine($"Problem 3 solution: {largestPrimeFactor}");
        }

        private static long GetLargestPrimeFactor(long numberToCalculateLargestPrimeFactor)
        {
            long largestPrimeFactor = 2;
            while(largestPrimeFactor * largestPrimeFactor <= numberToCalculateLargestPrimeFactor)
            {
                if (numberToCalculateLargestPrimeFactor % largestPrimeFactor ==0)
                    numberToCalculateLargestPrimeFactor /= largestPrimeFactor;
                else
                    ++largestPrimeFactor;
            }
            return numberToCalculateLargestPrimeFactor;
        }
    }
}
