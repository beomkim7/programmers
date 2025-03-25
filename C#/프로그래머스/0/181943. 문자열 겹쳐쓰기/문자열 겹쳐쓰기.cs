using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
string answer = "";
            answer = my_string.Remove(s, overwrite_string.Length).Insert(s,overwrite_string);
            return answer;
    }
}