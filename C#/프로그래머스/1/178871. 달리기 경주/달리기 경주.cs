using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
string[] answer = (string [])players.Clone();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++) dict[players[i]] = i;
            
            foreach(string s in callings)
            {
                int now = dict[s];

                if(now > 0)
                {
                    string prevName = answer[now - 1]; 

                    answer[now - 1] = s;
                    answer[now] = prevName;

                    dict[s]--;
                    dict[prevName]++;
                }

            }
            

            return answer;
    }
}