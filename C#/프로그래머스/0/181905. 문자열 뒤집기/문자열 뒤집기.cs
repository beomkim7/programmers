using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
            string answer = "";
            char[] kCheck = my_string.ToCharArray();

            Array.Reverse(kCheck, s, e - s + 1);
            answer = new string(kCheck);
            return answer;
    }
}