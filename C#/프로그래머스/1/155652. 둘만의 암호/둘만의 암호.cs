using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s, string skip, int index) {
 string answer = "";

            foreach(char c in s)
            {
                List<char> cArray = new List<char>();
                char check = c;
                while (cArray.Count < index)
                {
                    check++;
                    if (check > 'z') check = 'a';
                    if (skip.Contains(check))
                    {
                        
                        continue;
                    }
                    else cArray.Add(check);
                }
                answer += check;

            }

            return answer;
    }
}