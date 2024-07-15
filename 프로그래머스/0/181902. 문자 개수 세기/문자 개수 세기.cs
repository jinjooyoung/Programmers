using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        int index = 0;
        int count = 0;
        
        for (int i = 0; i < my_string.Length; i++)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (my_string[i] == c)
                {
                    answer[count]++;
                }
                count++;
            }
            for (char t = 'a'; t <= 'z'; t++)
            {
                if (my_string[i] == t)
                {
                    answer[count]++;
                }
                count++;
            }
            count = 0;
        }
        
        return answer;
    }
}