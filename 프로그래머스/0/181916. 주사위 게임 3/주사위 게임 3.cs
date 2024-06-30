using System;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        
        if (a == b & a == c & a == d)
        {
            answer = 1111*a;
            return answer;
        }
        
        if (a == b && a == c)   answer = (int)Math.Pow(10*a + d, 2);
        if (a == b && a == d)   answer = (int)Math.Pow(10*a + c, 2);
        if (a == c && a == d)   answer = (int)Math.Pow(10*a + b, 2);
        if (b == c && b == d)   answer = (int)Math.Pow(10*b + a, 2);
        
        if (a == b && c == d && a != c)     answer = (a+c)*(int)Math.Abs(a-c);
        if (a == c && b == d && a != b)     answer = (a+b)*(int)Math.Abs(a-b);
        if (a == d && b == c && a != b)     answer = (a+b)*(int)Math.Abs(a-b);
        
        if (a == b && a != c && a != d && c != d) answer = c*d;
        if (a == c && a != b && a != d && b != d) answer = b*d;
        if (a == d && a != b && a != c && b != c) answer = b*c;
        if (b == c && b != a && b != d && a != d) answer = a*d;
        if (b == d && b != a && b != c && a != c) answer = a*c;
        if (c == d && c != a && c != b && a != b) answer = a*b;
        
        if (a != b && b != c && c != d && a != d && a != c && b != d)
        {
            int[] nums = {a, b, c, d};
            int min = 6;
            
            for (int i = 0; i < 4; i++)
            {
                min = (int)Math.Min(min, nums[i]);
            }
            
            answer = min;
        }
        
        return answer;
    }
}