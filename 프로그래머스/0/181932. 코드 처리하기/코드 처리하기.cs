using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;
        
        for (int i = 0; i < code.Length; i++)   // i는 code의 idx
        {
            if (mode == 0)
            {
                if (code[i] != '1') 
                {
                    if (i%2 == 0)   answer += code[i];
                }
                else    mode = 1;
            }
            else if (mode == 1)
            {
                if (code[i] != '1') 
                {
                    if (i%2 == 1)   answer += code[i];
                }
                else    mode = 0;
            }
        }
        if (answer == "")
        {
            answer = "EMPTY";
            return answer;
        }
        return answer;
    }
}