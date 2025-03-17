using System;

public class Solution {
    public string[] solution(string my_str, int n) {
            int anwerL = my_str.Length % n == 0 ? my_str.Length / n : my_str.Length / n + 1;
            string[] answer = new string[anwerL];
            int Length = my_str.Length;

            for(int i = 0; i<answer.Length; i++)
            {
                if(Length >= n)
                {
                    answer[i] = my_str.Substring(i*n, n);
                    Length -= n;
                }
                else answer[i] = my_str.Substring(i * n, Length);
            }
            return answer;
    }
}