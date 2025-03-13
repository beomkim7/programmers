using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] emergency) {
            int[] orders = emergency.OrderByDescending(x => x).ToArray();
            int[] answer = emergency.Select(x => Array.IndexOf(orders, x) + 1).ToArray();

            return answer;
    }
}