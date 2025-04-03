using System;
using System.Linq;
public class Solution {
    public int solution(int n) {
            int answer = 0;
            for (int i = 4; i <= n; i++)
                answer += Enumerable.Range(1, n).Count(x => i % x == 0) > 2 ? 1 : 0;
        return answer;
    }
}