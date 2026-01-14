using System;
using System.Linq;
class Solution 
{
    public int solution(int n) 
   {
int answer = 0;
            int nCnt = Convert.ToString(n,2).Count(x => x == '1');

            for(int i = n + 1; i < int.MaxValue; i++)
            {
                int checkCnt = Convert.ToString(i,2).Count(x => x == '1');
                if (nCnt == checkCnt)
                {
                    answer = i;
                    break;
                }
            }

            return answer;
    }
}