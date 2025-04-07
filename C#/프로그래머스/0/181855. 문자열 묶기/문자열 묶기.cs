using System;using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
            int answer = strArr.GroupBy(x=>x.Length)
                                .OrderByDescending(x=>x.Count())
                                .First().Count();
            return answer;
    }
}