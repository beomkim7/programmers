using System;
using System.Linq;
public class Solution {
    public int solution(string before, string after) {
int answer = 
            string.Concat(before.OrderBy(x => x)) == string.Concat(after.OrderBy(x => x)) ? 1 : 0;
            return answer;
    }
}