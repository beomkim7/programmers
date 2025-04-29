using System;

public class Solution {
    public int solution(string A, string B) {
            int answer = 0;

            for(int i = 0; i < A.Length; i++)
            {
                if (A.Equals(B)) break;

                string temp = B.Substring(0, 1);
                B = B.Remove(0, 1) + temp;

                answer++;
            }

            if (A.Length == answer) answer = -1;

            return answer;
    }
}