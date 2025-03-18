using System;

public class Solution {
    public int solution(int balls, int share) {
        if (balls < share) return 0;  // 예외 처리

        long answer = 1; // 오버플로우 방지를 위해 long 사용

        for (int i = 0; i < share; i++) {
            answer *= (balls - i);
            answer /= (i + 1);
        }

        return (int) answer; // int 범위 내에서 변환
    }
}