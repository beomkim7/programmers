using System;using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
            string answer = "";

            foreach(char c in s)
            {
                int count = 0;
                char temp = c;

                while (count < index)
                {
                    if (temp == 'z') temp = 'a';
                    else temp++;

                    if (skip.Contains(temp)) continue;

                    count++;
                }
                answer += temp;
            }

            return answer;
    }
}