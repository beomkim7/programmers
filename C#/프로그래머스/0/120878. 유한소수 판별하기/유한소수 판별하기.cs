using System;

public class Solution {
        public int solution(int a, int b)
        {
            int answer = 0;
            int check = GDC(a, b);
            b /= check;
            while (b!=1)
            {
                if (b % 2 == 0) b /= 2;
                else if (b % 5 == 0) b /= 5;
                else break;
            }
            answer = b == 1 ? 1 : 2;
            return answer;
        }

        public int GDC(int a, int b) //7,20     11,22                                           12,21
        {
            if (b == 0) return a;
            else return GDC(b, a%b); // 20,7 => 7,6 => 6,1 =>1,1        22,11=>11,0             21,9=> 9,3 => 3,0=>>7
        }
}