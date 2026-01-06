using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
            Stack<char> st = new Stack<char>();
            foreach(char c in s)
            {
                if (c == '(') st.Push(c);
                else
                {
                    if (st.Count == 0) return false;
                    st.Pop();
                }                
            }

            bool answer = st.Count==0;
            return answer;
    }
}