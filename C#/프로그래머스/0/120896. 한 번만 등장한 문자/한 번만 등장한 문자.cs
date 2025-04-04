using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
string answer = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i])) dict[s[i]] += 1;
                else dict.Add(s[i], 1);
            }

            foreach (char c in dict.Keys)
                if (dict[c] == 1) answer += c;

            answer = new string(answer.OrderBy(x => x).ToArray());

            return answer;
    }
}