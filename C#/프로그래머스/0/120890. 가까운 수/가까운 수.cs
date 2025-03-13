using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] array, int n) {
            int answer = array.OrderBy(x=>x).OrderBy(x=>Math.Abs(x-n)).ToArray().FirstOrDefault();

            return answer;
    }
}