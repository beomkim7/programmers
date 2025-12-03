using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
            int[] answer = new int[2];
            int result = 0;            

            for(int i = 0; i < win_nums.Length; i++)
            {
                if (lottos.Contains(win_nums[i])) result++;
            }

            int bonus = lottos.Where(x => x == 0).Count()+result;

            int max = Math.Min(7 - bonus, 6);
            int min = Math.Min(7 - result, 6);
            answer[0] = max;
            answer[1] = min;

            return answer;
    }
}