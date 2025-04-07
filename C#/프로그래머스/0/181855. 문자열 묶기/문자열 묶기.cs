using System;using System.Linq;


public class Solution {
    public int solution(string[] strArr) {
int[] intArr = new int[31];
            for (int i = 0; i < strArr.Length; i++)
                intArr[strArr[i].Length] += 1;

            return intArr.Max();
    }
}