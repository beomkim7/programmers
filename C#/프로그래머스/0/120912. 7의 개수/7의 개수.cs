using System;
using System.Linq;
public class Solution {
    public int solution(int[] array) {
int answer = string.Join("", array).Count(x => x == '7');
            return answer;
    }
}