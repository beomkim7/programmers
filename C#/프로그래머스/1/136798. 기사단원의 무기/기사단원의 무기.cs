using System;
using System.Linq;using System.Collections.Generic;
public class Solution {
    public int solution(int number, int limit, int power) {
            int answer = 0;

            List<int> nArr = new List<int>();
            int check = 1;
            while (check <= number)
            {
                int num = 1;
                for (int i = 1; i <= check / 2; i++)
                    if (check % i == 0) num++;
                nArr.Add(num);                
                check++;
            }
            Console.WriteLine(string.Join(",", nArr));
            answer += nArr.Where(x => x <= limit).Sum();
            answer += nArr.Where(x => x > limit).Count() * power;

            return answer;
    }
}