using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
int[] answer = new int[2];

            int[] lottosArr = new int[46];
            int[] winArr = new int[46];

            for(int i = 0; i < lottos.Length; i++)
            {
                lottosArr[lottos[i]]++;
                winArr[win_nums[i]]++;
            }

            int commCnt = 0;
            for (int i = 0; i <= 45; i++)
                if (lottosArr[i] == 1 && winArr[i] == 1) commCnt++;

            int bonusCnt = lottos.AsEnumerable().Where(x=>x==0).Count();

            int Cnt = commCnt + bonusCnt;
            //65432
            //12345 else6

            if (commCnt == 0) commCnt=1;
            if (Cnt == 0) Cnt=1;

            answer[1] = 7 - commCnt;
            answer[0] = 7 - Cnt;

            return answer;
    }
}