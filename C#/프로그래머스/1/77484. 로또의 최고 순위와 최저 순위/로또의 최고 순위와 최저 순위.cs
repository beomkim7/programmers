using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
            int[] answer = new int[2];

            int rank = 7;
            int count = lottos.AsEnumerable().Where(x => x == 0).Count();

            lottos = lottos.AsEnumerable().OrderByDescending(x => x).ToArray();
            win_nums = win_nums.AsEnumerable().OrderByDescending(x => x).ToArray();

            for (int i = 0; i < lottos.Length; i++)
                if (win_nums.Contains(lottos[i])) rank--;

            answer[0] = rank - count==7?6:rank-count;
            answer[1] = rank==7?6:rank;

            return answer;
    }
}