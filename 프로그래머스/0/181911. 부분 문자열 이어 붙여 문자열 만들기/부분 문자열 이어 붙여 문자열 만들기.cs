using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        int s = 0;
        int e = 0;
        
        for (int i = 0; i < my_strings.Length; i++)
        {
            s = parts[i,0];
            e = parts[i,1];
            
            answer += my_strings[i].Substring(s, e-s+1);
        }
        
        return answer;
    }
}