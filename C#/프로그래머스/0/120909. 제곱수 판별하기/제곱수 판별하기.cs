using System;

public class Solution {
    public int solution(int n) {
        int answer = 2;
        if(int.TryParse(Math.Sqrt(n).ToString(),out int result))answer = 1;
        return answer;
    }
}