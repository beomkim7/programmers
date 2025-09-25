using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string X, string Y) {
string answer = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char c in Y)
            {
                if (dict.ContainsKey(c)) dict[c]++;
                else dict[c] = 1;
            }

            List<char> comm = new List<char>();

            foreach(char c in X)
            {
                if (dict.ContainsKey(c) && dict[c] > 0)
                {
                    comm.Add(c);
                    dict[c]--;
                }
            }

            if (comm.Count > 0)
            {
                answer = new string(comm.OrderByDescending(x => x).ToArray());
                if (int.TryParse(answer, out int result) && result == 0) answer = "0";
            }
            else answer = "-1";

            return answer;
    }
}