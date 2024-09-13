using System;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int count = 0;
        
        while (count!=arr.Length)
        {
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= 50 && arr[i]%2 == 0)
                {
                    arr[i] = arr[i]/2;
                }
                else if (arr[i] < 50 && arr[i]%2 != 0)
                {
                    arr[i] = arr[i]*2+1;
                }
                else
                {
                    arr[i] = arr[i];
                    count++;
                }
            }
            answer++;
        }
        
        return answer-1;
    }
}