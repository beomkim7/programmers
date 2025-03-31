using System;
using System.Linq;
public class Solution {
    public string[] solution(string myString) {
string[] answer = myString.Split(new string[] { "x" }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToArray();
            return answer;
    }
}