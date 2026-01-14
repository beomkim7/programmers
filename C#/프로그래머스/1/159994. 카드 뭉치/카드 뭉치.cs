using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
                        string answer = "Yes";
            int One = 0;
            int Two = 0;

            foreach(string s in goal)
            {
                if (cards1.Length > One && cards1[One] == s ) One++;
                else if (cards2.Length > Two  &&cards2[Two] == s) Two++;
                else
                {
                    answer = "No";
                    break;
                }
            }

            return answer;
    }
}