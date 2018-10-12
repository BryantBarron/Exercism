using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        bool[] alphabet = new bool[26];
        int letters = 0;
        for (int i = 0; i < input.Length; i++) {
            if ('A' <= input[i] && input[i] <= 'Z')
            {
                letters = input[i] - 'A';
            }
            else if ('a' <= input[i] && input[i] <= 'z')
            {
                letters = input[i] - 'a';

            }
            alphabet[letters] = true;
        }

        for (int i = 0; i <= 25; i++){
            if (alphabet[i] == false)
                return false;
        }

        return (true);
    }
}
