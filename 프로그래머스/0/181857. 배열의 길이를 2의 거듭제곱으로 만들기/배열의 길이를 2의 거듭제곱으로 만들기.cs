using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        double a = 0;  // result의 목표 길이
        int count = 0;  // 지수
        
        while(a < arr.Length)
        {
            a = Math.Pow(2, count);
            count++;
        }
        
        if (a == arr.Length)
        {
            return arr;
        }
        else
        {
            for (int i = 0; i < a; i++)
            {
                if (i < arr.Length)
                {
                    answer.Add(arr[i]);
                }
                else
                {
                    answer.Add(0);
                }
            }
        }
        
        return answer.ToArray();
    }
}