using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int number, int limit, int power) {
            int answer = 0;
            List<int> check = new List<int>();
            for(int i = 1; i <=number; i++)
            {
                int num = 0;
                for(int j = 1; j*j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        num++;
                        if (j != i / j) num++;
                    }
                }
                check.Add(num);
            }
Console.WriteLine(string.Join(",", check));
            answer = check.Where(x => x <= limit).Sum();
            answer += check.Where(x => x > limit).Count() * power;

            return answer;
    }
}