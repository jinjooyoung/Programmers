using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        
        Dictionary<string, int> d = new Dictionary<string, int>();
        
        for (int i = 0; i < players.Length; i++)
        {
            d.Add(players[i], i);
        }
        
        foreach (var call in callings)
        {
            int a = d[call];
            string temp = players[a];
            players[a] = players[a-1];
            players[a-1] = temp;
            
            d[call] = a-1;
            d[players[a]] = a;
        }
        
        return players;
    }
}