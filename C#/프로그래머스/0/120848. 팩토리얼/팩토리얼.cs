using System;

public class Solution {
    public int solution(int n) {
    int answer = 1;
    int check = 1;

    while (check * (answer + 1) <= n)
    {
        answer++;
        check *= answer;
    }

    return answer;
    }
}