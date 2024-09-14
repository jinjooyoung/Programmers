using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        
        foreach (char a in my_string)
        {
            if (a.ToString() == alp)
            {
                var temp = a.ToString();
                answer += temp.ToUpper();
            }
            else
            {
                answer += a;
            }
        }
        
        return answer;
    }
}