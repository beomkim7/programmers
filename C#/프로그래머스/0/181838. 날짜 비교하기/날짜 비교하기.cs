using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
            DateTime dt1 = new DateTime(date1[0], date1[1], date1[2]);
            DateTime dt2 = new DateTime(date2[0], date2[1], date2[2]);
            int answer = (dt2-dt1).Days;
            return (answer>0)?1:0;
    }
}