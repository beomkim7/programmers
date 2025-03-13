using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
            string answer = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i])) dict[s[i]] = 1;
                else dict[s[i]] += 1;
            }

           answer = string.Join("",dict.Where(x => x.Value == 1).Select(x=>x.Key).OrderBy(x=>x));

            return answer;
    }
}