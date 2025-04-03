using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
            int[] check = arr.Select((value, index) => new { value, index })
                .Where(x => x.value == 2)
                .Select(x => x.index)
                .ToArray();
            int start = check.FirstOrDefault();
            int last = check.LastOrDefault();
            if (check.Length == 0) return new int[] { -1 };
            else if(check.Length == 1) return new int[] { 2 };
            else
            {
                int[] result = Enumerable.Range(start, last-start+1).Select(x => arr[x]).ToArray();
                return result;

            }
    }
}