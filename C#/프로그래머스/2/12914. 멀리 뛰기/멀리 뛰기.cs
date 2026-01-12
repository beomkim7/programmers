public class Solution {
    public long solution(int n) {
                                             if (n == 1) return 1;
            if (n == 2) return 2;
            long answer = 0;
            long[] nArr = new long[n+1];
            nArr[1] = 1;
            nArr[2] = 2;
            if (n >= 3)
            {
                for (int i = 3; i <= n; i++)
                    nArr[i] = (nArr[i - 1] + nArr[i - 2])% 1234567;
            }
            answer = nArr[n];
            return answer;
    }
}