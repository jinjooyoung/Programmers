using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if (n%2==0)
        {
            for (int i = 1; i <= n/2; i++)
            {
                answer += (i*2)*(i*2);
            }
        }
        else
        {
            for (int i = 1; i <= n/2 + 1; i++)
            {
                answer += i*2 - 1;
            }
        }
        
        return answer;
    }
}