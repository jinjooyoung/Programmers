using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        int n = 0;
        
        for (int i = 1; i < numLog.Length; i++)
        {
            n = numLog[i] - numLog[i - 1];
            switch (n)
            {
                case 1:
                    answer += "w";
                    break;
                case -1:
                    answer += "s";
                    break;
                case 10:
                    answer += "d";
                    break;
                case -10:
                    answer += "a";
                    break;
            }
        }
        return answer;
    }
}