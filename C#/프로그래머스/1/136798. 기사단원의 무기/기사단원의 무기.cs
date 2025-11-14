using System;
using System.Linq;
public class Solution {
    public int solution(int number, int limit, int power) {
            int answer = 0;

            int check = 1;
            int[] arr = new int[number];
            while (check <= number)
            {
                int num = 0;
                for(int i = 1; i * i <= check; i++)
                {
                    if (check % i == 0)
                    {
                        num++;
                        if (i != check / i) num++;
                    }                    
                }
                arr[check-1] = num;
                check++;
            }

            answer += arr.Where(x => x <= limit).Sum();
            answer += arr.Where(x => x > limit).Count() * power ;

            return answer;
    }
}