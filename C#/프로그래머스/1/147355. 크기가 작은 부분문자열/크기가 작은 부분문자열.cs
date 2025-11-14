using System;

public class Solution {
    public int solution(string t, string p) {
            int answer = 0;
            int num = t.Length - p.Length;

            for(int i = 0; i <= num; i++)
            {                
                string target = t.Substring(i, p.Length);

                if (string.Compare(target, p) <= 0) answer++;
            }
            return answer;
    }
}