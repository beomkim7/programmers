using System;using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
            string[] answer = (string[])players.Clone();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int i = 0; i < players.Length; i++) dict[players[i]] = i;

            for(int i = 0; i < callings.Length; i++)
            {
                int cur = dict[callings[i]];
                int prev = dict[callings[i]]-1;

                answer[cur] = answer[prev];
                answer[prev] = callings[i] ;

                dict[answer[cur]] = cur;
                dict[answer[prev]] = prev;
            }


            return answer;
    }
}