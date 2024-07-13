using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = my_string.Substring(0,s);
        char[] a = new char[e-s+1];
        
        for (int i = 0; i < e-s+1; i++)
        {
            a[i] = my_string[i+s];
        }
        for (int i = e-s; i >= 0; i--)
        {
            answer += a[i];
        }
        answer += my_string.Substring(e+1);
        
        return answer;
    }
}