using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        return Enumerable.Range(1, max).Sum().Square();
    }

    public static int CalculateSumOfSquares(int max)
    {
        return (Enumerable.Range(1, max).Sum(n => n.Square()));
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }

    public static int Square(this int n){
        return n * n;
    }
}