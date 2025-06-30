using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
            int[] answer = new int[s.Length];
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i])) answer[i] = i - dict[s[i]];
                else answer[i] = -1;

                dict[s[i]] = i;
            }

            return answer;
    }
}