using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string X, string Y) {
 string answer = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char c in X)
            {
                if (dict.ContainsKey(c)) dict[c]++;
                else dict[c] = 1;
            }

            List<char> numLst = new List<char>();

            foreach(char c in Y)
            {
                if(dict.ContainsKey(c) && dict[c] > 0)
                {
                    numLst.Add(c);
                    dict[c]--;
                }
            }

            answer = new string(numLst.OrderByDescending(x => x).ToArray());
            if (numLst.Count == 0) answer = "-1";
            else if (int.TryParse(answer, out int result) && result == 0) answer = "0";

            return answer;
    }
}