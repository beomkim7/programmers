using System;

public class Solution {
    public string solution(string myString, string pat) {
            int index = myString.LastIndexOf(pat) + pat.Length;
            string answer = myString.Substring(0,index);
            return answer;
    }
}