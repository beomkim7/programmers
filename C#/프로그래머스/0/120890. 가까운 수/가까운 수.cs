using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] array, int n) {
            int answer = 0;
            int[] check = (int[])array.Clone();
            List<int> nums = new List<int>();

            for(int i = 0; i <array.Length;i++) check[i] = Math.Abs(array[i] - n);

            for (int i = 0; i < array.Length; i++)
                if (check.Min() == check[i]) nums.Add(array[i]);

            answer = nums.ToArray().Min();

            return answer;
    }
}