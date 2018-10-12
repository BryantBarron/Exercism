using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] array = nucleotide.ToCharArray();

        for (int i = 0; i < array.Length; i++){
            if(array[i] == 'G'){
                array[i] = 'C';
            }else if(array[i] == 'C'){
                array[i] = 'G';
            }else if(array[i] == 'T'){
                array[i] = 'A';
            }else if(array[i] == 'A'){
                array[i] = 'U';
            }
        }
        string nucelo = new String(array);
        return nucelo;
    }
}