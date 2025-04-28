using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
List<int> stk = new List<int>();
            int count = 0;
            while(count < arr.Length)
            {
                if(stk.Count == 0 || stk[stk.Count - 1] < arr[count])
                {
                    stk.Add(arr[count]);
                    count++;
                }else if(stk[stk.Count - 1] >= arr[count]) stk.RemoveAt(stk.Count-1);
            }

            return stk.ToArray();
    }
}