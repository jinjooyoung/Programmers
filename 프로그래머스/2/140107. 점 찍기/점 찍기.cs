using System;

public class Solution {
    public long solution(int k, int d) {
        long answer = 0;
        long dd = (long)Math.Pow((long)d,2);
        
        for (long x = 0; x <= d; x+=k)
        {
            long maxY = (long)Math.Floor(Math.Sqrt(dd-Math.Pow(x,2)));   // 현재 x값에서 answer에 포함할 수 있는 최대 y값
            
            answer += maxY/k + 1;
        }
        
        return answer;
    }
}