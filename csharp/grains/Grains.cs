﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        ulong square;

        if(n < 1 || n > 64){
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        return square = (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        return Enumerable.Range(1, 64).Select(Square).Aggregate((x, y) => x + y);
    }
}