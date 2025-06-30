using System;
using System.Linq;
public class Solution {
    public int solution(int[] d, int budget) {
            int answer = 0;
            if (d.Sum() == budget) answer = d.Length;
            else
            {
                int check = 0;
                d = d.OrderBy(x => x).ToArray();
                for(int i = 0; i < d.Length; i++)
                {
                    check += d[i];
                    if (check <= budget)
                        answer++;
                }

            }

            return answer;
    }
}