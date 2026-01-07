using System;
using System.Linq;
public class Solution {
    public int solution(int number, int limit, int power)         {
            int answer = 0;
            int[] nCount = new int[number];
            for(int i = 1; i <= number; i++)
            {
                int cnt = devide(i);
                if (cnt > limit) nCount[i - 1] = power;
                else nCount[i - 1] = cnt; ;
            }
            answer = nCount.Sum();

            return answer;
        }

        public int devide(int i)
        {
            int cnt = 0;
            for(int n = 1; n * n <= i; n++)
            {
                if (i % n == 0)
                {
                    if (n * n == i) cnt++;
                    else cnt += 2;
                }
            }
            return cnt;
        }
}