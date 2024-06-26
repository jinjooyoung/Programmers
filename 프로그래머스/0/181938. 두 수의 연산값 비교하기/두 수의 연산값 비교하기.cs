using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        int abI = Int32.Parse($"{a}{b}");
        int ab = 2 * a * b;
        
        answer = Math.Max(abI,ab);
        
        return answer;
    }
}