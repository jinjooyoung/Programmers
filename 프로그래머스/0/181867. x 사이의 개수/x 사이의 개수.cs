using System;

public class Solution {
    public int[] solution(string myString) {
        string[] oCount = myString.Split('x');
        int[] answer = new int[oCount.Length];
        
        
        for (int i = 0; i < oCount.Length; i++)
        {
            answer[i] = oCount[i].Length;
        }
        return answer;
    }
}