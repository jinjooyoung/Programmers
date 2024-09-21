using System;

public class Solution {
    public int solution(string myString, string pat) {
        string aToBbToA = "";
        
        foreach (char a in myString)
        {
            if (a == 'A')
            {
                aToBbToA += 'B';
            }
            else
            {
                aToBbToA += 'A';
            }
        }
        
        if (aToBbToA.Contains(pat))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}