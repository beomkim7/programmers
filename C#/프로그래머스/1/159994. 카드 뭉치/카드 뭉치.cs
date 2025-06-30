using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
            string answer = "No";

            int one = 0;
            int two = 0;

            for(int i = 0; i < goal.Length; i++)
            {
                if (one<cards1.Length&&cards1[one] == goal[i]) one++;
                else if (two < cards2.Length&&cards2[two] == goal[i]) two++;
            }
            if (one + two == goal.Length) answer = "Yes";

            return answer;
    }
}