using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%2==0 && arr[i] >= 50)
            {
                answer[i] = arr[i]/2;
            }
            else if(arr[i]%2==1 && arr[i] < 50)
            {
                answer[i] = arr[i]*2;
            }
            else
            {
                answer[i] = arr[i];
            }
        }
        
        return answer;
    }
}