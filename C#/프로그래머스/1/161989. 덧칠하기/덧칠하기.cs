using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
            int answer = 0;
            int index = 0;

            while (index < section.Length)
            {
                int start = section[index];
                int end = start + m - 1;
                
                while (index < section.Length && section[index] <= end)
                    index++;


                answer++;
            }


            return answer;
    }
}