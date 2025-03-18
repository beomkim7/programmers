using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
            int[] answer = new int[2];

            Dictionary<string, int[]> dict = new Dictionary<string, int[]>() 
            {
                {"left",new int[]{-1,0} },
                {"right",new int[]{1,0} },
                {"down",new int[]{0,-1} },
                {"up",new int[]{0,1} }
            };

            foreach(string check in keyinput)
            {
                if (dict.ContainsKey(check))
                {
                    answer[0] += dict[check][0];
                    answer[1] += dict[check][1];
                }

                answer[0] = Math.Max(-board[0] / 2, Math.Min(answer[0], board[0] / 2));
                answer[1] = Math.Max(-board[1] / 2, Math.Min(answer[1], board[1] / 2));
            }



            return answer;
    }
}