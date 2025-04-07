using System;

public class Solution {
    public int solution(string myString, string pat) {
int answer = 0;

            for(int i = 0; i < myString.Length; i++)
                if (i + pat.Length <= myString.Length && myString.Substring(i, pat.Length) == pat) answer++;

            return answer;
    }
}