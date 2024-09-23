using System;

public class Solution {
    public string solution(string rny_string) {
        if (rny_string.Contains('m'))
        {
            
            return rny_string.Replace("m", "rn");
        }
        else
        {
            return rny_string;
        }
    }
}