using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
int[] answer = new int[2];
            int fNum = 0;
            int sNum = 0;
            foreach(int i in lottos)
            {
                if (i == 0) { sNum++; continue; }
                if (win_nums.Contains(i)) fNum++;
            }
            sNum += fNum;
            if (sNum > 1) answer[0] = 7 - sNum;
            else answer[0] = 6;

            if (fNum > 1) answer[1] = 7 - fNum;
            else answer[1] = 6;
            return answer;
    }
}