using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.NetCore.CSharp
{
    public static class Problem4
    {
        public static void Solve()
        {
            var allPalindromes = new List<string>();
            for (int firstNumberToCheck = 999; firstNumberToCheck >= 100; firstNumberToCheck--)
            {
                for (int numberToCreateProductWith = 999; numberToCreateProductWith >= 100; numberToCreateProductWith--)
                {
                    var product = firstNumberToCheck * numberToCreateProductWith;
                    if (IsPalindrome(product.ToString()))
                        allPalindromes.Add(product.ToString());
                }
            }
            Console.WriteLine($"Problem 4 solution: {allPalindromes.Select(x => Convert.ToInt32(x)).OrderByDescending(x => x).First()}");
        }

        private static bool IsPalindrome(string stringToCheck)
        {
            var forward = stringToCheck.ToCharArray();
            return forward.SequenceEqual(forward.Reverse());
        }
    }
}
