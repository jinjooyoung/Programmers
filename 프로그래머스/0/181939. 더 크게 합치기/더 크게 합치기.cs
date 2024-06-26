using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string abS = a.ToString() + b.ToString();
        string baS = b.ToString() + a.ToString();
        int abI = int.Parse(abS);
        int baI = int.Parse(baS);
        
        answer = Math.Max(abI, baI);
        
        return answer;
    }
}