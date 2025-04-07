using System;using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = array.Sum(x=>x.ToString().Where(y=>y.ToString()=="7").Count());
        return answer;
    }
}