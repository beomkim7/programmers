using System;

public class Solution {
    public int[] solution(int[] arr) {
            int length = 0;
            for (int i = 1; i < arr.Length*2; i *= 2)
                if (i >= arr.Length) length = i;

            int[] answer = new int[length];

            for (int i = 0; i < arr.Length; i++)
                answer[i] = arr[i];
            

            return answer;
    }
}