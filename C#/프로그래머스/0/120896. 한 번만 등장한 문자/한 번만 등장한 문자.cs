using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
            string answer = new string (s.GroupBy(x => x, y => y, (x, y) => new { key = x, value = y.Count() })
                                .Where(x => x.value == 1)
                                .Select(x => x.key)
                                .OrderBy(x => x)
                                .ToArray());
            return answer;
    }
}