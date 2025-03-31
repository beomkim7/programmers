using System;

public class Solution {
    public int solution(int chicken) {
            int answer = 0;
            int coupon = chicken;

            while (coupon >= 10)
            {
                int check = coupon / 10;
                answer += check;
                coupon = coupon % 10 + check;
            }
            Console.Write(coupon);
            Console.Write(answer);
            


            return answer;
    }
}