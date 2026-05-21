using System;

public class Solution {
    public int[] solution(string s) {
            int[] answer = new int[s.Length];

            string check = "";
            for(int i = 0 ; i < s.Length ; i++)
            {
                if(!check.Contains(s[i])) answer[i] = -1;
                else answer[i]= check.Length - check.LastIndexOf(s[i]);
                
                check += s[i];
            }
            return answer;
    }
}