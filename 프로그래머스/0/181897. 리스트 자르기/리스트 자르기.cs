using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        List<int> numbers = new List<int>();

        if (n == 1)
        {
            for (int i = 0; i <= slicer[1]; i++)
            {
                numbers.Add(num_list[i]);
            }
        }
        else if (n == 2)
        {
            for (int i = slicer[0]; i < num_list.Length; i++)
            {
                numbers.Add(num_list[i]);
            }
        }
        else if (n == 3)
        {
            for (int i = slicer[0]; i <= slicer[1]; i++)
            {
                numbers.Add(num_list[i]);
            }
        }
        else if (n == 4)
        {
            for (int i = slicer[0]; i <= slicer[1]; i += slicer[2])
            {
                numbers.Add(num_list[i]);
            }
        }

        return numbers.ToArray();
    }
}