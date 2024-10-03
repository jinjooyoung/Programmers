using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int arr_1 = 0;
        int arr_2 = 0;
        
        if(arr1.Length > arr2.Length)
        {
            return 1;
        }
        else if (arr1.Length < arr2.Length)
        {
            return -1;
        }
        else
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr_1 += arr1[i];
                arr_2 += arr2[i];
            }
            if (arr_1 > arr_2)
            {
                return 1;
            }
            else if (arr_1 < arr_2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}