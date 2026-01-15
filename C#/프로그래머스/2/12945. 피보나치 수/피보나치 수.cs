public class Solution {
    public int solution(int n) {
                        if (n == 1) return 1;
            if (n == 2) return 1;
            int answer = 0;
            int[] nArr = new int[n + 1];
            nArr[1] = 1;
            nArr[2] = 1;
            for(int i = 3; i <= n; i++)
            {
                nArr[i] = (nArr[i - 1] + nArr[i - 2])%1234567;
            }
            answer = nArr[n];
            return answer;
    }
}