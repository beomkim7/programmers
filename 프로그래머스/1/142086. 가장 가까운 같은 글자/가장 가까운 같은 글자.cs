using System;

public class Solution {
    public int[] solution(string s) {
            int[] answer = new int[s.Length];

            string st = "";
            for(int i = 0 ; i < s.Length; i++)
            {
                if (!st.Contains(s[i]))
                {
                    st +=s[i];
                    answer[i] = -1;
                }
                else
                {
                    int check = st.LastIndexOf(s[i]);
                    st += s[i];
                    answer[i] = st.LastIndexOf(s[i]) - check;
                }
            }

            return answer;
    }
}