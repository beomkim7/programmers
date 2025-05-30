public class Solution {
    public bool solution(int x) {
        bool answer = true;
                    int check2 = 0;
        int num = x;
            while (x > 0)
            {
                check2 += x % 10;
                x /= 10;
            }
            if (num % check2 != 0) answer = false;

            return answer;
        return answer;
    }
}