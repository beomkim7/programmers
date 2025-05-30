using System.Linq;
public class Solution {
    public int[] solution(long n) {
            string[] nums = n.ToString().Select(x => x.ToString()).Reverse().ToArray();

            int[] answer = nums.Select(x=>int.Parse(x)).ToArray();
            return answer;
    }
}