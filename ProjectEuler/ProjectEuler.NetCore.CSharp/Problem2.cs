using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.NetCore.CSharp
{
    public static class Problem2
    {
        public static void Solve()
        {
            var fibonacciNumbers = GetAllFibonacciNumbers(4000000);
            var sumOfEvenValuedTerms = fibonacciNumbers.Where(x => x % 2 == 0).Sum();
            Console.WriteLine($"Problem 2 solution: {sumOfEvenValuedTerms}");
        }
        private static List<int> GetAllFibonacciNumbers(int maxTermValue)
        {
            var fibonacciNumbers = new List<int>() {0,1 };
            int a = 0, b = 1;
            do
            {
                var tmp = a + b;
                fibonacciNumbers.Add(tmp);
                a = b;
                b = tmp;
            } while (b < maxTermValue);
            return fibonacciNumbers;
        }
    }
}
