using System.Linq;
public class Solution {
    public long solution(long n) {
            long answer = long.Parse(new string(n.ToString().Select(x=>x)
                                        .OrderByDescending(x=>x)
                                        .ToArray()));


            return answer;
    }
}