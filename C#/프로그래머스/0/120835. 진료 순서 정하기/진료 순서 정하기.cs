using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] emergency) {
            int[] answer = emergency.OrderByDescending(x=>x).ToArray();
            emergency = emergency.Select(x => Array.IndexOf(answer, x) + 1).ToArray();
            return emergency;
    }
}