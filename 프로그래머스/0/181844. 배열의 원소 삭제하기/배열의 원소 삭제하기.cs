using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> arrList = arr.ToList();
        
        foreach(var a in delete_list)
        {
            bool b = arr.Contains(a);
            
            if (b)
            {
                arrList.Remove(a);
            }
        }
        return arrList.ToArray();
    }
}