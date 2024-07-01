using System;

public class Solution {
    string answer = "";
        int s = 0;
        int e = 0;
    string a = "";
    
    public string solution(string my_string, int[,] queries) {
        a = my_string;
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            s = queries[i, 0];
            e = queries[i, 1];
            A(s, e);
        }
        
        return a;
    }
    
    
    
    
    public string A(int s, int e)
    {
        if (s == 0 && e != a.Length-1)
        {
            for (int i = e; i >= s; i--)
            {
                answer += a[i];
            }
            answer += a.Substring(e+1);
        }
        else if (s != 0 && e == a.Length-1)
        {
            answer += a.Substring(0,s);
            for (int i = e; i >= s; i--)
            {
                answer += a[i];
            }
        }
        else if (s == 0 && e == a.Length-1)
        {
            for (int i = e; i >= s; i--)
            {
                answer += a[i];
            }
        }
        else
        {
            answer += a.Substring(0,s);
            for (int i = e; i >= s; i--)
            {
                answer += a[i];
            }
            answer += a.Substring(e+1);
        }
        
        a = answer;
        answer = "";
        return a;
    }
}