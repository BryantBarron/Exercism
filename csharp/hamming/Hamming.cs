using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int distance = 0;
        if(firstStrand.Length == secondStrand.Length){
            for (int i = 0; i < firstStrand.Length &&
                 i < secondStrand.Length; i++){
                if(firstStrand[i] != secondStrand[i]){
                    distance++;
                }
            }
        }else{
            throw new System.ArgumentException("DNA strigns do not match");
        }
        return distance;
    }
}