using System;

public class Solution {
    public int[] solution(int[,] score) {
            int length = score.GetLength(0);
            int[] answer = new int[score.GetLength(0)] ;
            

            int[] avgLst = new int[score.GetLength(0)];

            for (int i = 0; i < length; i++)
            {
                avgLst[i] = score[i, 0] + score[i, 1];
                answer[i] = 1;
            }


            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    if (avgLst[i] < avgLst[j]) answer[i]++;

            return answer;
    }
}