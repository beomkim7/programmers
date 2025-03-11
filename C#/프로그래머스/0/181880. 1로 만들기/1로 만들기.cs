using System;

public class Solution {
    public int solution(int[] num_list) {
            int answer = 0;

            for(int i = 0; i < num_list.Length; i++)
            {
                int temp = num_list[i];
                while (temp > 1)
                {
                    temp /= 2;
                    answer++;
                }
            }
                

            return answer;
    }
}