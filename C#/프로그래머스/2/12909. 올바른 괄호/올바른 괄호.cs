using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public bool solution(string s) {
            bool answer = true;
            int num = 0;

            Stack<char> st = new Stack<char>();
            while(num < s.Length)
            {
                if (s[num] == '(') st.Push(s[num]);
                else
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    else st.Pop();
                }
                num++;
            }
            answer = st.Count() == 0;
            return answer;
    }
}