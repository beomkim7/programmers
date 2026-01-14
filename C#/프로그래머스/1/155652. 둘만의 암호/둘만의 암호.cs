using System;
using System.Linq;
public class Solution {
    public string solution(string s, string skip, int index) {
            string answer = "";
            char[] sArr = s.ToArray();
            foreach (char c in sArr)
            {
                int check = 0;
                char now = c;
                while (check < index)
                {
                    ++now;
                    if (now - '0' > 74) now = 'a';
                    if (skip.Contains(now)) continue;
                    check++;
                }
                answer += now;
            }
                
            return answer;
    }
}