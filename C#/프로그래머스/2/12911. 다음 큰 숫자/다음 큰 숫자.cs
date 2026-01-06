using System;
using System.Linq;
class Solution 
{
    public int solution(int n) 
   {
            int answer = n;

            int CheckN = Convert.ToString(n, 2).Count(x => x == '1');
            while (true)
            {
                answer += 1;
                int answerN = Convert.ToString(answer, 2).Count(c => c == '1');
                if (CheckN == answerN) break;
            }

            return answer;
    }
}