using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Kata.CSharp
{
    public static class Fibonacci
    {
        public static IList<int> GetFibonacciSuit(int maxTake)
        {
            var fibonacciList = new List<int>();

            if (maxTake == 1)
            {
                 fibonacciList.Add(0);
                 return fibonacciList;
            }

            fibonacciList.Add(1);
            Enumerable.Range(1,maxTake - 1)
                .ToList()
                .ForEach(f => fibonacciList.Add((f <= 2 ? 1 : fibonacciList[f - 2] + fibonacciList[f - 1])));


            return fibonacciList;
        }

    }
}
