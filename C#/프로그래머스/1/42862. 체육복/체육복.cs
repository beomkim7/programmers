using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
int answer = 0;

            List<int> lostLst = lost.OrderBy(x => x).ToList();
            List<int> reserveLst = reserve.OrderBy(x => x).ToList();

            List<int> inter = lostLst.Intersect(reserveLst).ToList();
            lostLst = lostLst.Except(inter).ToList();
            reserveLst = reserveLst.Except(inter).ToList();

            
            foreach(int r in reserveLst)
            {
                for(int i = r - 1; i <= r + 1; i++)
                {
                    if (lostLst.Contains(i))
                    {
                       lostLst.Remove(i);                        
                        break;
                    }
                }
            }


            answer = n - lostLst.Count;

            return answer;
    }
}