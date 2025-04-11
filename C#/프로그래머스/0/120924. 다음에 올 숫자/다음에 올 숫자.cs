using System;

public class Solution {
    public int solution(int[] common) {
            int answer = 0;

            if (common[1] - common[0] == common[2] - common[1]) answer = common[0] + (common[1] - common[0]) * common.Length;
            else
            {
                int ratio = common[1] / common[0];
                answer = common[common.Length - 1] * ratio;
            }


            return answer;
    }
}