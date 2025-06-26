using System;

public class Solution {
    public int solution(int[] number) {
            int answer = 0;
            for(int i = 0; i < number.Length-2; i++)
            {
                for(int j = i+1; j < number.Length-1; j++)
                {
                    
                    for(int z = j+1; z < number.Length; z++)
                    {                        
                        if (number[i] + number[j] + number[z] == 0) answer++;
                    }
                }
            }

            return answer;
    }
}