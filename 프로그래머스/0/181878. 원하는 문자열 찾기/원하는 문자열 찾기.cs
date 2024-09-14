using System;

public class Solution {
    public int solution(string myString, string pat) {
        string lowerString = myString.ToLower();
        string lowerPat = pat.ToLower();

        if (lowerString.Contains(lowerPat))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}