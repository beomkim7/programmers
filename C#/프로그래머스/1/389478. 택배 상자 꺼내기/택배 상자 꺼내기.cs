using System;

public class Solution {
    public int solution(int n, int w, int num) {
int answer = 1;
            int currentNum = num;

            while (true)
            {
                int currentRow = (currentNum - 1) / w; //12 
                int num_col;
                if(currentRow % 2 == 0)
                {
                    num_col = (currentNum - 1) % w;
                }
                else
                {
                    num_col = w - 1 - ((currentNum - 1) % w); //054321 => 012345
                }

                int nextRow = currentRow + 1;
                int startNum = nextRow * w +1;

                int nextNum;

                if(nextRow %2 == 0)
                {
                    nextNum = startNum + num_col;
                }
                else
                {
                    nextNum = startNum + (w - 1 - num_col);    //6-1-      17
                }

                if (nextNum > n) break;
                else
                {
                    // 위에 상자가 존재하면 (치워야 할 상자)
                    answer++;
                    currentNum = nextNum; // 다음으로 치워야 할 상자 번호로 갱신
                }
            }

            return answer;
    }
}