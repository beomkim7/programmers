using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
            int[] answer = arr.Where(x => x % divisor == 0)
                                .OrderBy(x => x)
                                .DefaultIfEmpty(-1)
                                .ToArray();



            return answer;
    }
}