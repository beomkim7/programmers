using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[] query) {
            List<int> answer = new List<int>(arr);
            
            for(int i = 0; i < query.Length; i++)
            {

                if (query[i] < 0 || query[i] >= answer.Count)
                {
                    // 범위를 벗어나는 query 값 방어
                    continue;
                }
                int temp = 0;
                temp = answer[query[i]];
                if (i % 2 == 0)
                {
                    if (query[i] < answer.Count)
                    {
                        answer.RemoveRange(query[i], answer.Count - query[i]);
                        answer.Add(temp);
                    }
                }
                else
                {
                    if (query[i] <= answer.Count)
                        answer.RemoveRange(0, query[i]);
                }
            }

            return answer.ToArray();
    }
}