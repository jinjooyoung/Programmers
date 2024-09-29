using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> answer = new List<int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (!answer.Contains(arr[i]))   // answer에 arr[i]가 존재하지 않는다면
            {
                answer.Add(arr[i]);     // 리스트에 추가
                if (answer.Count == k) break;   // k개 도달하면 멈춤
            }
        }

        while (answer.Count < k)    // k개보다 적다면
        {
            answer.Add(-1); // -1을 리스트에 추가
        }

        return answer.ToArray();
    }
}