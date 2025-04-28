using System;using System.Linq;

public class Solution {
    public int solution(int[] sides) {
            int answer = 0;
            int max = sides.Max();
            int min = sides.Min();

            for (int i = max - min + 1; i <= max; i++) answer++;
            for (int i = max + 1; i < max + min; i++) answer++;

            return answer;
    }
}