using System;

public class Solution {
    public int solution(int chicken) {
            int answer = 0;
            int coupon = 0;

            while(chicken > 0)
            {                
                answer += chicken / 10;                                         //108 , 118 , 119 ,119
                coupon += chicken % 10;                                         //1 ,   9   , 9 , 10
                if(coupon >= 10)     
                {
                    answer += coupon / 10;                                      //120
                    coupon = chicken % 10;                                      
                }
                chicken /= 10;                                                  //108   ,10   ,1 ,0                                    

            }
            return answer;
    }
}