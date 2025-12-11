using System;

public class Solution {
    public int solution(int n, int w, int num) {
            int answer = 1;

            int currentNum = num;

            while (true)
            {
                int currentRow = (currentNum - 1) / w;

                int currentPlus;
                if (currentRow % 2 == 0) currentPlus = (currentNum - 1) % w;
                else currentPlus = w - 1 - ((currentNum - 1) % w);//8 = 17

                int nextRow = currentRow + 1;
                int nextNum = nextRow * w + 1;

                if (nextRow % 2 == 0) nextNum += currentPlus;
                else nextNum += w - 1 - currentPlus;

                if (nextNum > n) break;
                else
                {
                    answer++;
                    currentNum = nextNum;
                }
            }

            return answer;
    }
}