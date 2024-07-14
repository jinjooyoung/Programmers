using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        int a = 0;
        
        if (m==1)
        {
            answer = my_string;
        }
        else
        {
            for(int i = 0; i < my_string.Length/m; i++)
            {
                answer += my_string[i * m + (c - 1)];
            }
        }
        
        return answer;
    }
}