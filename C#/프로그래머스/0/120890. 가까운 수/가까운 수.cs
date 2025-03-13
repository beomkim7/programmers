using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] array, int n) {
int answer = array.OrderBy(x => x).FirstOrDefault(x => Math.Abs(x - n) == array.Min(o => Math.Abs(o-n)));

            return answer;
    }
}