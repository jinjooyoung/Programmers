using System;
using System.Collections.Generic;

public class Solution {
    List<int> a = new List<int>();
    int i;
    
    public int[] solution(int n) {
        i = n;
        a.Add(i);
        
        R();
        
        return a.ToArray();
    }
    
    void R() {
        if (i == 1)
            return;
        
        if (i % 2 == 0) {
            i = i / 2;
            a.Add(i);
            R();
        } else {
            i = 3 * i + 1;
            a.Add(i);
            R();
        }
    }
}
