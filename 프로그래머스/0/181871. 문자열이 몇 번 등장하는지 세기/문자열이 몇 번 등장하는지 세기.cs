using System;

public class Solution {
    public int solution(string myString, string pat) {
        int count = 0;
        int index = 0;

        while ((index = myString.IndexOf(pat, index)) != -1)
        {
            count++;
            index++;
        }

        return count;
    }
}