using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
            List<int> answer = new List<int>();
            int index = 0;
            while(index < arr.Length)
            {
                if (answer.Count == 0 || answer[answer.Count - 1] != arr[index]) answer.Add(arr[index]);
                else if (answer[answer.Count - 1] == arr[index]) answer.RemoveAt(answer.Count - 1);
                index++;

                
            }

            return answer.ToArray().Count()==0?new int[] { -1 }:answer.ToArray();
    }
}