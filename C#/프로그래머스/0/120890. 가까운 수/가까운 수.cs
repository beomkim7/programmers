using System;
using System.Linq;
public class Solution {
    public int solution(int[] array, int n) {
int[] check = array.Select(x => Math.Abs(x - n)).ToArray();

            int answer = array.Select(x => new { key = x, value = Math.Abs(x - n) })
                                .Where(x => x.value == check.Min())
                                .Select(x => x.key).OrderBy(x => x).First();

                            
            
            return answer;
    }
}