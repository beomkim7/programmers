using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
            int answer = 1;
            int num = 0;
            int check = section[num] + m - 1;

            while(num <= section.Length-1)
            {
                if(check < section[num])
                {
                    answer++;
                    check = section[num] + m - 1;
                }
                num += 1;
            }

            return answer;
    }
}