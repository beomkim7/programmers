using System;
using System.Linq;
class Solution 
{
    public int solution(int n) 
   {
            int answer = n;

            string nCheck = Convert.ToString(n, 2);
            int nNum = nCheck.Count(x=>x=='1');
            while (true)
            {
                answer+=1;
                int answerNum = Convert.ToString(answer, 2).Count(x => x == '1');
                if (answerNum == nNum) break;
            }

            return answer;
    }
}