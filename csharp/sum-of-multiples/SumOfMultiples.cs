using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {

        return Enumerable.Range(1, max - 1)
                         .Where(n => multiples
                                .Any(multiple => multiple != 0 &&  n % multiple == 0)).Sum();
    }
}