using System;

public class Solution {
    public int solution(int n, int w, int num) {
int answer = 1;
            int currentNum = num;

            while (true)
            {
                int currentRow = (currentNum - 1) / w;

                int row_num;
                if (currentRow % 2 == 0) row_num = (currentNum - 1) % w;
                else row_num = w - 1 - ((currentNum - 1) % w);

                int nextRow = currentRow + 1;
                int nextNum = nextRow * w + 1;

                if (nextRow % 2 == 0) nextNum += row_num;
                else nextNum += w - 1 - row_num;

                if (nextNum > n) break;
                else
                {
                    currentNum = nextNum;
                    answer++;
                }

            }

            return answer;
    }
}