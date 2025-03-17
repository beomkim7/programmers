using System;

public class Solution {
    public int solution(string[] order) {
            int answer = 0;
            foreach(string check in order)
            {
                if (check.Contains("latte")) answer += 5000;
                else answer += 4500;
            }
            return answer;
    }
}