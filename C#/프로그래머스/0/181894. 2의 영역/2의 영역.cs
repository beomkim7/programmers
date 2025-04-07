using System;using System.Linq;using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
            int[] answer = arr.Select((index,order)=>new {index,order })
                              .Where(x=>x.index == 2)
                              .Select(x=>x.order)
                              .ToArray();

            int st = answer.FirstOrDefault();
            int ed = answer.LastOrDefault();

            List<int> result = new List<int>();
            if (st == 0 && ed ==0) result.Add(-1);
            else if(ed == st) result.Add(2); 
            else
            {
                               for (int i = st; i <= ed; i++) result.Add(arr[i]);
            }

            return result.ToArray();
    }
}