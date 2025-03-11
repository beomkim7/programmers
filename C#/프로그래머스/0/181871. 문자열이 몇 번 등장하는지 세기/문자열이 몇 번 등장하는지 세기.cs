using System;

public class Solution {
    public int solution(string myString, string pat) {
            int answer = 0;
            int index = myString.IndexOf(pat);

            while (index != -1)
            {
                answer++;
                index = myString.IndexOf(pat, index + 1);

            }

            return answer;
    }
}