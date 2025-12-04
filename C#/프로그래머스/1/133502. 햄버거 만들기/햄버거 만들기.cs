using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int[] ingredient) {
            int answer = 0;
            Stack<int> st = new Stack<int>();

            foreach(int i in ingredient)
            {
                st.Push(i);

                if (st.Count >= 4)
                {
                    List<int> lst = st.Take(4).Reverse().ToList();

                    if(lst.SequenceEqual(new List<int> {1,2,3,1 }))
                    {
                        answer++;
                        for (int j = 0; j < lst.Count; j++) st.Pop();
                    }
                }
            }

            return answer;
    }
}