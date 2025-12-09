using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
int answer = 0;
            List<int> interArr = reserve.Intersect(lost).ToList();
            

            List<int> reserArr = reserve.Except(interArr).OrderBy(x => x).ToList();
            List<int> lostArr = lost.Except(interArr).OrderBy(x => x).ToList();

            for(int i = 0; i < reserArr.Count; i++)
            {
                int first = reserArr[i] - 1;
                int second = reserArr[i] + 1;
                if (lostArr.Contains(first))
                {
                    lostArr.Remove(first);
                    continue;
                }
                else if (lostArr.Contains(second)) lostArr.Remove(second);

            }
            answer = n - lostArr.Count();

            return answer;
    }
}