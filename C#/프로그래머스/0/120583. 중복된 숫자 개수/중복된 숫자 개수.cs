using System;
using System.Linq;
public class Solution {
    public int solution(int[] array, int n) {
            int answer = array.Where(x=>x==n).Count();
            return answer;
    }
}