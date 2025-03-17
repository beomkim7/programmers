using System;
using System.Linq;
public class Solution {
    public string solution(int q, int r, string code) {
            string answer = "";

            answer = new string(code.Where((x, index) => index % q == r).ToArray());
            
            return answer;
    }
}