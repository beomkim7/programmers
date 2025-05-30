using System;
using System.Linq;
public class Solution {
    public int solution(int n) {
            int answer = n.ToString().Select(x=>x.ToString())
                                        .ToArray()
                                        .Select(x=>int.Parse(x))
                                        .Sum();
            return answer;
    }
}