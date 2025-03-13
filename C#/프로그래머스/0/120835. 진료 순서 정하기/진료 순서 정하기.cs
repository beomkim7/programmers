using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] emergency) {
            int[] answer = new int[emergency.Length];

            for (int i = 0; i < emergency.Length; i++) answer[i] = emergency.Length - i;

            Array.Sort(emergency, answer);
            return answer;
    }
}