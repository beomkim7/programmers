using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
            int[] answer = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                if(direction == "right")
                {
                    if (i != numbers.Length - 1) answer[i+1] = numbers[i];
                    else answer[0] = numbers[numbers.Length-1];
                }
                else
                {
                    if (i == numbers.Length - 1) answer[i] = numbers[0];
                    else answer[i] = numbers[i + 1];
                }
            }
            return answer;
    }
}