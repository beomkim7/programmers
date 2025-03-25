using System;

public class Solution {
    public int solution(int[] sides) {
int answer = 0;

            int first = Math.Min(sides[0],sides[1]);
            int end = Math.Max(sides[0], sides[1]);

            for (int i = end - first+1; i <= end; i++) answer++;
            for (int i = end+1; i < first + end; i++) answer++;

            return answer;
    }
}