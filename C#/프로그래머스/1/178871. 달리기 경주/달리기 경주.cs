using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] players, string[] callings) {
string[] answer = new string[players.Length];

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < players.Length; i++) dict.Add(players[i], i);

            foreach(string s in callings)
            {
                int now = dict[s];
                int next = dict[s] - 1;

                string nowS = players[now];
                string NextS = players[next];

                players[now] = players[next];
                players[next] = nowS;

                dict[nowS] = next;
                dict[NextS] = now;

            }

            return players;
    }
}