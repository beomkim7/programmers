using System;
using System.Linq;
public class Solution {
    public int solution(int i, int j, int k) {
        int answer = Enumerable.Range(i, j - i +1).Sum(x => x.ToString().Count(y => y.ToString() == k.ToString()));
            return answer;
    }
}