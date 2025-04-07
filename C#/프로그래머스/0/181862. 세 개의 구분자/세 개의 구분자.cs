using System;

public class Solution {
    public string[] solution(string myStr) {
            char[] check = new char[] { 'a', 'b', 'c' };
            string[] answer = myStr.Split(check, StringSplitOptions.RemoveEmptyEntries);

            return answer.Length == 0 ? new string[] { "EMPTY" } : answer;
    }
}