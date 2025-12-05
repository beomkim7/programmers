using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
int[] answer = new int[2];
            int length = lottos.Length;

            int bonus = 0;
            int result = 0;
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    if (lottos[i] == win_nums[j])
                    {
                        result++;
                        break;
                    }
                }
            }

            bonus = lottos.Where(x => x == 0).Count() + result;
            //6 5 4 3 2 1 
            //1 2 3 4 5 6
            bonus = Math.Min(6, 7- bonus);
            result = Math.Min(6, 7 - result);

            answer[0] = bonus;
            answer[1] = result;

            return answer;
    }
}