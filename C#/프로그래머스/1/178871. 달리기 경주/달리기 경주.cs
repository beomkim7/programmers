using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] players, string[] callings) {
string[] answer = (string[])players.Clone();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++) dict.Add(players[i], i);

            for(int i =0; i < callings.Length; i++)
            {                
                int now = dict[callings[i]];

                if(now > 0)
                {
                    string front = answer[now - 1];

                    answer[now - 1] = answer[now];
                    answer[now] = front;

                    dict[front]++;
                    dict[callings[i]]--;
                }

            }

            return answer;
    }
}