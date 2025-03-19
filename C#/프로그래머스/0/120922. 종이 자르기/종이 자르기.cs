using System;

public class Solution {
    public int solution(int M, int N) {
            int answer = 0;

            for (int i = 0; i < M * N - 1; i++)
                answer++;
            return answer;
    }
}