using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        string s = "";
        int a = 0;
        
        foreach (char c in number)
        {
            s = c.ToString();
            a += Int32.Parse(s);
        }
        
        return a%9;
    }
}