using System;

public class Solution {
    public int solution(string binomial) {
        string[] splited = binomial.Split(' ');
        int answer = 0;
        int a = Int32.Parse(splited[0]);
        int b = Int32.Parse(splited[2]);
        
         switch (splited[1])
         {
            case "+":
                answer = a + b;
                break;
            case "-":
                answer = a - b;
                break;
            case "*":
                answer = a * b;
                break;
        }
        return answer;
    }
}