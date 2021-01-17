using System;
using System.Linq;

namespace ProjectEuler.NetCore.CSharp
{
    public static class Problem1
    {
        public static void Solve()
        {
            var sumOfAllMultiples = Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine($"Problem 1 solution: {sumOfAllMultiples}");
        }
    }
}
