using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n) {
            List<int> answer = new List<int>();

            for(int i = 2; i <= n; i++)
                while (n % i == 0)
                {
                    n /= i;
                    answer.Add(i);
                }

            answer.Distinct();
            return answer.Distinct().ToArray();
    }
}