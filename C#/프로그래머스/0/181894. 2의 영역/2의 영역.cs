using System;

public class Solution {
    public int[] solution(int[] arr) {
int st = Array.IndexOf(arr, 2);
            int ed = Array.LastIndexOf(arr, 2);

            if (st == -1) return new int[] { -1 };
            else if (st == ed) return new int[] { 2 };
            else
            {
                int[] answers = new int[ed - st + 1];          
                Array.Copy(arr, st, answers, 0, ed - st + 1);  

                return answers;

            }
    }
}