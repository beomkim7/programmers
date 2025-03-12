using System;

public class Solution {
    public int[] solution(int[] arr) {
            int temp = 1;

            while (temp < arr.Length)
            {
                temp *= 2;
            }

            Array.Resize(ref arr, temp);
            return arr;
    }
}