using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] reversed = input.ToCharArray();
        Array.Reverse(reversed);
        return new string(reversed);
    }
}