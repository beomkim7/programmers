using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
            int[] answer = new int[2];
            int count = 7;
            int bonus = 0;
            foreach(int i in lottos)
            {
                if (i == 0) bonus--;
                else
                {
                    if (win_nums.Contains(i)) count--;
                }
            }
            answer[0] = (count + bonus) == 7?6: (count + bonus);
            answer[1] = count == 7?6:count;

            return answer;
    }
}