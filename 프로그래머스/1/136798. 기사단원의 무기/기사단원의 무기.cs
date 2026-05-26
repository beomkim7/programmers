using System;

public class Solution {
public int solution(int number, int limit, int power)
        {
            int answer = 0;

            int[] numArr = new int[number];

            for(int i = 1; i <= number; i++)
            {
                numArr[i-1] = GDC(i);
            }

            for(int i = 0 ; i < numArr.Length; i++)
            {
                if(numArr[i]>limit)answer+=power;
                else answer += numArr[i];
            }


            return answer;
        }

        public int GDC(int a)
        {
            int num = 1;
            for(int i = 1; i <= a / 2; i++)
                if(a % i==0)num++;
            return num;
        }
}