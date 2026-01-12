using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
            bool answer = true;

            int num = 0;
            Queue<char> que = new Queue<char>();
            while (num < s.Length)
            {
                if (s[num] == '(') que.Enqueue('(');
                else
                {
                    if (que.Count > 0) que.Dequeue();
                    else
                    {
                        answer = false;
                        break;
                    }
                }
                num++;
            }
if (que.Count != 0) answer = false;
            return answer;
    }
}