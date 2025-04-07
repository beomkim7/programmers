using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
            List<int> answer = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (flag[i])
                    answer.AddRange(Enumerable.Repeat(arr[i], arr[i] * 2));
                else
                    answer.RemoveRange(answer.Count()-arr[i],arr[i]);
            }

            return answer.ToArray();
    }
}