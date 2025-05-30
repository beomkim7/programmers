using System;using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
            int answer = 0;
            List<int> check = new List<int>();
            for (int i = 1; i < n; i++)
                if (n % i == 1) check.Add(i);
            answer = check.Min();

            return answer;
    }
}