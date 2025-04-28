using System;

public class Solution {
    public string solution(int q, int r, string code) {
            string answer = "";

            for (int i = r; i < code.Length; i += q)
                answer += code[i].ToString();
                
            

            return answer;
    }
}