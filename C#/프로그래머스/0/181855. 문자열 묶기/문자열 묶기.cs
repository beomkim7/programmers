using System;
using System.Linq;
public class Solution {
    public int solution(string[] strArr) {
                    int answer = strArr.GroupBy(x => x.Length)
                                .Max(x => x.Count());
            return answer;
    }
}