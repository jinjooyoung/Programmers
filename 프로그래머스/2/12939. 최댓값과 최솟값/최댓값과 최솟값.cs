using System;

public class Solution {
    public string solution(string s) {
        string[] strNumbers = s.Split(' ');     // 공백으로 자르고
        int[] numbers = Array.ConvertAll(strNumbers, int.Parse);    // 문자열을 int로 변환
        
        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        
        foreach (int num in numbers)
        {
            if (num < minNum) minNum = num;
            if (num > maxNum) maxNum = num;
        }
        return $"{minNum} {maxNum}";
    }
}