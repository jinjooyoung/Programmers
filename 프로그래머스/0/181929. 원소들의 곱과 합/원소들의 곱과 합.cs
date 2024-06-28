using System;

public class Solution {
    public int solution(int[] num_list) {
        int ad = 1;
        int square = 0;
        
        for (int i = 0; i < num_list.Length; i++)
        {
            ad = ad * num_list[i];
            square += num_list[i];
        }
        square = (int)Math.Pow(square, 2);
        
        return (ad > square ? 0 : 1);
    }
}