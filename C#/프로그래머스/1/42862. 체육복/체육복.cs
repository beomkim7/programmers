using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
int answer = 0;

            List<int> listLst = lost.ToList();
            List<int> reserveLst = reserve.ToList();

            List<int> Lst = new List<int>();
            
            for(int i = 0; i < reserveLst.Count(); i++)            
                if (listLst.Contains(reserveLst[i])) Lst.Add(reserveLst[i]);
            
            for(int i = 0; i < Lst.Count(); i++)
            {
                listLst.Remove(Lst[i]);
                reserveLst.Remove(Lst[i]);
            }

            listLst = listLst.OrderBy(x => x).ToList();
            reserveLst = reserveLst.OrderBy(x => x).ToList();
            for(int i = 0; i < reserveLst.Count(); i++)
            {
                int beforCheck = reserveLst[i] - 1;
                if (listLst.Contains(beforCheck))
                {
                    listLst.Remove(beforCheck);
                    continue;
                }

                int afterCheck = reserveLst[i] + 1;
                if (listLst.Contains(afterCheck)) listLst.Remove(afterCheck);
            }

            answer = n - listLst.Count();

            return answer;
    }
}