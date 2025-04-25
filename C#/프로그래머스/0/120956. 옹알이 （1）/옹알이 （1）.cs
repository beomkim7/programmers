using System;

public class Solution {
    public int solution(string[] babbling) {
            int answer = 0;

            for(int i = 0; i < babbling.Length; i++)
            {
                babbling[i] = babbling[i].Replace("aya", " ");
                babbling[i] = babbling[i].Replace("ye", " ");
                babbling[i] = babbling[i].Replace("woo", " ");
                babbling[i] = babbling[i].Replace("ma", " ");

                if (babbling[i].Trim() == "") answer++;
            }

            return answer;
    }
}