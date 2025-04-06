using System;using System.Linq;

public class Solution {
    public int solution(int a, int d, bool[] included) {
            int answer = Enumerable.Range(0,included.Length).Where(x=>included[x]).Select(x => a + d * x).Sum();
            return answer;
    }
}