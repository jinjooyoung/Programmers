using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = true;
        bool x12 = false;
        bool x34 = false;
        
        if (x1 == true || x2 == true)
        {
            x12 = true;
        }
        
        if (x3 == true || x4 == true)
        {
            x34 = true;
        }
        
        if (x12 == false || x34 == false)
        {
            answer = false;
        }
        
        return answer;
    }
}