using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int k) {
            int[] answer = new int[k];

            arr = arr.Distinct().ToArray();

            for(int i = 0; i < k; i++)
            {
                if (i < arr.Length) answer[i] = arr[i];
                else answer[i] = -1;
            }

            return answer;
    }
}