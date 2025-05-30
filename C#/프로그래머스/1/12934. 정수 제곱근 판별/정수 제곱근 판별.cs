using System;
public class Solution {
    public long solution(long n) {
            long answer = -1;
            string check = Math.Sqrt(n).ToString();
            if (int.TryParse(check, out int result)) answer = (long)Math.Pow((double)result+1,(double)2);
            Math.Sqrt(n);
            return answer;
    }
}