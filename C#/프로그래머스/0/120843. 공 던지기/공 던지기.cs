using System;

public class Solution {
    public int solution(int[] numbers, int k) {
            int answer = 0;

            int length = 2 * (k - 1);
                answer = numbers[length % numbers.Length];
            return answer;
    }
}